let load = document.querySelector(".PreLoad");
const moveId = localStorage.getItem("moveId");

load.style.display = "flex"
load.style.animation = "si alternate ease-in forwards"

function detallesPelicula(moveId) {
  // id de pelicula
  // informacion sobre la pelicula-------------------------
  const infoPelicula = async () => {
    try {
      const respuesta = await fetch(
        `https://api.themoviedb.org/3/movie/${moveId}?api_key=001eb5474c1b52412b728d71a0ef4514&language=es-MX`
      );
      console.log(respuesta);

      if (respuesta.status === 200) {
        const json = await respuesta.json();
        console.log(json);

        //--------Sinopsis---------------

        let sinopsis = `<p>${json.overview}</p>`;

        document.getElementById("sinopsis").innerHTML = sinopsis;

        //--------------Front Text-----------------

        const minutos = json.runtime;
        const horas = Math.floor(minutos / 60);
        const minutosR = minutos % 60;
        let title = `<div class="txt">
            <h2>${json.title}</h2>
            <p>(${json.release_date}) ${horas}h${minutosR}m  ⭐${json.vote_average}</p>
            <div id="video"></div>
            </div>`;

        document.getElementById("frontText").innerHTML = title;

        //-------------Background Imagen-------------------

        document.getElementById(
          "foto"
        ).style.backgroundImage = `url('https://image.tmdb.org/t/p/original/${json.backdrop_path}')`;

        //-----------------trailer-----------------------
        const fetchTrailer = async () => {
          try {

            const apiKey = '001eb5474c1b52412b728d71a0ef4514';

            const videoSearch = await fetch(`https://api.themoviedb.org/3/movie/${moveId}/videos?api_key=${apiKey}`);

            if (videoSearch.status === 200) {
              const videoData = await videoSearch.json();
              const trailerId = videoData.results.find(vid => vid.type === 'Trailer' && vid.site === 'YouTube');

              if (trailerId) {
                const trailerUrl = `https://www.youtube.com/embed/${trailerId.key}`;
                const iframe = document.getElementById('video_trailer_url');
                iframe.src = trailerUrl;
              }
            }
          } catch (error) {
            console.log('Error:', error);
          }
        };


        fetchTrailer();
      }
    } catch (error) {
      console.log(error);
    }
  };

  infoPelicula();

  // ----------------Comentarios--------------

  const cargarReseñas = async () => {
    try {
      const respuesta = await fetch(
        `https://api.themoviedb.org/3/movie/${moveId}/reviews?api_key=001eb5474c1b52412b728d71a0ef4514`
      );
      console.log(respuesta);

      if (respuesta.status === 200) {
        const datos = await respuesta.json();
        console.log(datos);

        let comentarios = "";
        datos.results.forEach((comentario) => {
          let comentarioRecortado = comentario.content.substring(0, 200);
          let mostrarBotonLeerMas = comentario.content.length > 200;


          let fotoPerfil = "https://www.millsjewelers.com/wp-content/uploads/2023/02/mystery-person.jpg";
          if (comentario.author_details.avatar_path !== null) {
            if (comentario.author_details.avatar_path.startsWith("/http")) {
              fotoPerfil = comentario.author_details.avatar_path.slice(1);
            } else {
              fotoPerfil = `https://image.tmdb.org/t/p/w500/${comentario.author_details.avatar_path}`;
            }
          }

          comentarios += `
            <div class="comentario">
              <div class="imgUsuario">
                <img src="${fotoPerfil}" alt="">
              </div>
              <div class="comentarioUsuario">
                <h6>${comentario.author}</h6>
                ${mostrarBotonLeerMas
              ? `
                      <div class="comentarioTexto">
                        <p class="recortado">${comentarioRecortado}</p>
                        <p class="completo" style="display: none;">${comentario.content}</p>
                      </div>
                      <button onclick="mostrarComentarioCompleto(this)">Leer más</button>
                      <button onclick="mostrarComentarioRecortado(this)" style="display: none;">Leer menos</button>
                    `
              : `<p>${comentario.content}</p>`
            }
              </div>
            </div>
            <hr>
          `;
        });

        document.getElementById("reseñas").innerHTML = comentarios;
      } else if (respuesta.status === 401) {
        console.log("No está el título");
      } else if (respuesta.status === 404) {
        console.log("No se encontró");
      } else {
        console.log("Hubo un error");
      }
    } catch (error) {
      console.log(error);
    }
  };

  cargarReseñas();

  function mostrarComentarioCompleto(boton) {
    const comentarioTexto = boton.parentNode.querySelector(".comentarioTexto");
    const comentarioRecortado = comentarioTexto.querySelector(".recortado");
    const comentarioCompleto = comentarioTexto.querySelector(".completo");
    const botonLeerMas = boton;
    const botonLeerMenos = boton.nextSibling;

    comentarioRecortado.style.display = "none";
    comentarioCompleto.style.display = "block";
    botonLeerMas.style.display = "none";
    botonLeerMenos.style.display = "inline-block";
  }

  function mostrarComentarioRecortado(boton) {
    const comentarioTexto = boton.parentNode.querySelector(".comentarioTexto");
    const comentarioRecortado = comentarioTexto.querySelector(".recortado");
    const comentarioCompleto = comentarioTexto.querySelector(".completo");
    const botonLeerMas = boton.previousSibling;
    const botonLeerMenos = boton;

    comentarioRecortado.style.display = "block";
    comentarioCompleto.style.display = "none";
    botonLeerMas.style.display = "inline-block";
    botonLeerMenos.style.display = "none";
  }

  // ----------------reparto-------------
  const cargarReparto = async () => {
    try {
      const respuesta = await fetch(
        `https://api.themoviedb.org/3/movie/${moveId}/credits?api_key=001eb5474c1b52412b728d71a0ef4514`
      );
      console.log(respuesta);

      if (respuesta.status === 200) {
        const datos = await respuesta.json();
        console.log(datos);

        let actores = "";
        datos.cast.forEach((actor) => {
          let imagen = actor.profile_path
            ? `https://image.tmdb.org/t/p/w500/${actor.profile_path}`
            : "https://www.millsjewelers.com/wp-content/uploads/2023/02/mystery-person.jpg";
          actores += `
            <div class="cardReparto">
              <div class="imgActor">
                <img src="${imagen}" alt="">
              </div>
              <div class="nombreActor">
                <p>${actor.name}</p>
              </div>
            </div>
          `;
        });

        document.getElementById("reparto").innerHTML = actores;
      } else if (respuesta.status === 401) {
        console.log("No está el título");
      } else if (respuesta.status === 404) {
        console.log("No se encontró");
      } else {
        console.log("Hubo un error");
      }
    } catch (error) {
      console.log(error);
    }
  };

  cargarReparto();

  // ----------------similares------------------

  const peliculasSimilares = async () => {
    try {
      const respuesta = await fetch(
        `https://api.themoviedb.org/3/movie/${moveId}/similar?api_key=001eb5474c1b52412b728d71a0ef4514`
      );
      console.log(respuesta);

      if (respuesta.status === 200) {
        const datos = await respuesta.json();

        console.log(datos);

        let peliculas = "";
        datos.results.forEach((pelicula) => {
          let url = `https://image.tmdb.org/t/p/w500/${pelicula.poster_path}`;
          if (pelicula.poster_path == null) {
            url = "../img/error.png";
          }
          peliculas += `
                <div class="card">
                    <img class="open-details-movie" id="${pelicula.id}" src=${url} alt="">
                    <div id="titulo" class="titulo">
                       <h4>${pelicula.title}</h4>
                    </div>
                </div>
                `;
        });

        document.getElementById("similares").innerHTML = peliculas;
      } else if (respuesta.status === 401) {
        console.log("No esta el titulo");
      } else if (respuesta.status === 404) {
        console.log("No se encontro");
      } else {
        console.log("Hubo un error");
      }
    } catch (error) {
      console.log(error);
    }
  };

  peliculasSimilares();

  const trailer = async () => {
    try {
      const videoSearch = await fetch(
        `https://api.themoviedb.org/3/movie/${moveId}/videos?api_key=001eb5474c1b52412b728d71a0ef4514`
      );

      if (videoSearch.status === 200) {
        const videoData = await videoSearch.json();

        const trailerId = videoData.results.find(
          (vid) => vid.type === "Trailer"
        );

        if (trailerId) {
          const videoTrailer = `
            <div class="trailer">
              <a href="https://www.youtube.com/watch?v=${trailerId.key}" target="_blank">Ver trailer</a>
            </div>
          `;

          document.getElementById("video").innerHTML = videoTrailer;
        } else {
          console.log("No se encontró ningún trailer oficial.");
          const noTrailerMessage = `
            <div class="trailer">
              <p>No hay trailer oficial disponible.</p>
            </div>
          `;

          document.getElementById("video").innerHTML = noTrailerMessage;
        }
      } else if (videoSearch.status === 401) {
        console.log("No está el título");
      } else if (videoSearch.status === 404) {
        console.log("No se encontró");
      } else {
        console.log("Hubo un error");
      }
    } catch (error) {
      console.log(error);
    }
  };
};
window.onload = function () {
  detallesPelicula(moveId);
  load.style.animation = "no alternate ease-in forwards"
  load.style.display = "none"
};
