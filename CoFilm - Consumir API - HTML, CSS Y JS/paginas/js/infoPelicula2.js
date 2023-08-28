const serieId = localStorage.getItem("serieId");
let load = document.querySelector(".PreLoad")

load.style.display = "flex"
load.style.animation = "si alternate ease-in forwards"

function detallesSerie(serieId) {
  // informacion sobre la pelicula-------------------------

  const infoPelicula = async () => {
    try {
      const respuesta = await fetch(
        `https://api.themoviedb.org/3/tv/${serieId}?api_key=001eb5474c1b52412b728d71a0ef4514&language=es-MX`
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
        let name = `<div class="txt">
            <h2>${json.name}</h2>
            <p> ${json.first_air_date} ⭐${json.vote_average}</p>
            <div id="video"></div>
            </div>`;

        document.getElementById("frontText").innerHTML = name;

        //-------------Background Imagen-------------------

        document.getElementById(
          "foto"
        ).style.backgroundImage = `url('https://image.tmdb.org/t/p/original/${json.backdrop_path}')`;

        //-----------------trailer-----------------------
        const fetchTrailer = async () => {
          try {

            const apiKey = '001eb5474c1b52412b728d71a0ef4514';

            const videoSearch = await fetch(`https://api.themoviedb.org/3/tv/${serieId}/videos?api_key=001eb5474c1b52412b728d71a0ef4514`);

            if (videoSearch.status === 200) {
              const videoData = await videoSearch.json();
              const trailerId = videoData.results.find(vid => vid.type === 'Trailer' && vid.site === 'YouTube');

              if (trailerId) {
                const trailerUrl = `https://www.youtube.com/watch?v=${trailerId.key}`;
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
        `https://api.themoviedb.org/3/tv/${serieId}/reviews?api_key=001eb5474c1b52412b728d71a0ef4514`
      );
      console.log(respuesta);

      if (respuesta.status === 200) {
        const datos = await respuesta.json();
        console.log(datos);

        let comentarios = "";
        datos.results.forEach((comentario) => {
          let comentarioRecortado = comentario.content.substring(0, 200);
          let mostrarBotonLeerMas = comentario.content.length > 200;

          let fotoPerfil = "usuario.png";
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
        `https://api.themoviedb.org/3/tv/${serieId}/credits?api_key=001eb5474c1b52412b728d71a0ef4514`
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
        `https://api.themoviedb.org/3/tv/${serieId}/similar?api_key=001eb5474c1b52412b728d71a0ef4514`
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
                    <img src="https://image.tmdb.org/t/p/w500/${url}" alt="">
                    <div id="titulo" class="titulo">
                       <h4>${pelicula.name}</h4>
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
        `https://api.themoviedb.org/3/tv/${serieId}/videos?api_key=001eb5474c1b52412b728d71a0ef4514`
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

  // .-------------------------------------------------------------------------------------
};
window.onload = function () {
  detallesSerie(serieId);
  load.style.animation = "no alternate ease-in forwards"
  load.style.display = "none"
};
