let pagina = 1;
let load = document.querySelector(".PreLoad");

const btnAnterior = document.getElementById("btnAnterior");
const btnSiguiente = document.getElementById("btnSiguiente");
const tagsEl = document.getElementById("tags");
const genero = [
  {
    id: 28,
    name: "Action",
  },
  {
    id: 12,
    name: "Adventure",
  },
  {
    id: 16,
    name: "Animation",
  },
  {
    id: 35,
    name: "Comedy",
  },
  {
    id: 80,
    name: "Crime",
  },
  {
    id: 99,
    name: "Documentary",
  },
  {
    id: 18,
    name: "Drama",
  },
  {
    id: 10751,
    name: "Family",
  },
  {
    id: 14,
    name: "Fantasy",
  },
  {
    id: 36,
    name: "History",
  },
  {
    id: 27,
    name: "Horror",
  },
  {
    id: 10402,
    name: "Music",
  },
  {
    id: 9648,
    name: "Mystery",
  },
  {
    id: 10749,
    name: "Romance",
  },
  {
    id: 878,
    name: "Science Fiction",
  },
  {
    id: 10770,
    name: "TV Movie",
  },
  {
    id: 53,
    name: "Thriller",
  },
  {
    id: 10752,
    name: "War",
  },
  {
    id: 37,
    name: "Western",
  },
];

var selecgenero = [];
setgenero();

function setgenero() {
  tagsEl.innerHTML = "";
  genero.forEach((generos) => {
    const t = document.createElement("div");
    t.classList.add("tag");
    t.id = generos.id;
    t.innerText = generos.name;
    tagsEl.append(t);
    t.addEventListener("click", () => {
      if (selecgenero.length === 0) {
        selecgenero.push(generos.id);
      } else {
        if (selecgenero.includes(generos.id)) {
          selecgenero.forEach((id, idx) => {
            if (id === generos.id) {
              selecgenero.splice(idx, 1);
            }
          });
        } else {
          selecgenero.push(generos.id);
        }
      }

      console.log(selecgenero);
      const getMoviesURL = `https://api.themoviedb.org/3/discover/movie?sort_by=popularity.desc&api_key=3922568d95046025970a1b6575c3b3d7&language=es-MX&page=${pagina}`;
      getMovies(
        getMoviesURL + "&with_genres=" + encodeURI(selecgenero.join(",")),
        pagina
      );
      highlightSelection();
    });
    tagsEl.appendChild(t);
  });
}

function highlightSelection() {
  const tags = document.querySelectorAll(".tag");
  tags.forEach((tag) => {
    tag.classList.remove("highlight");
  });
  if (selecgenero.length != 0) {
    selecgenero.forEach((id) => {
      const hightlightedtag = document.getElementById(id);
      hightlightedtag.classList.add("highlight");
    });
  }
}

async function getMovies(url) {
  
  try {
    const respuesta = await fetch(url);
    console.log(respuesta);
    if (respuesta.status === 200) {
      const datos = await respuesta.json();
      let peliculas = "";
      datos.results.forEach((pelicula) => {
        peliculas += `
          <div class="card">
            <img class="open-details-movie" id="${pelicula.id}" src="https://image.tmdb.org/t/p/w500/${pelicula.backdrop_path}">
            <div class="titulo">
              <h4>${pelicula.original_title}</h4>
            </div>
          </div>
        `;
      });
      document.getElementById("contenedor").innerHTML = peliculas;
    } else if (respuesta.status === 401) {
      console.log("Colocaste la llave API incorrectamente.");
    } else if (respuesta.status === 404) {
      console.log("La película no se encuentra.");
    } else {
      console.log(
        "Error inesperado. No se pudo obtener la lista de películas."
      );
    }
  } catch (error) {
    console.log(error);
  }
}

btnSiguiente.addEventListener("click", () => {
  if (pagina < 2147483647) {
    pagina += 1;
    cargarpelicula();
  }
});
btnAnterior.addEventListener("click", () => {
  if (pagina > 1) {
    pagina -= 1;
    cargarpelicula();
  }
});

const recargar = document
  .querySelector(".NavLogo")
  .addEventListener("click", () => {
    window.location = "./index.html";
  });

const cargarpelicula = async () => {
  try {
    const respuesta = await fetch(
      `https://api.themoviedb.org/3/discover/movie?api_key=3922568d95046025970a1b6575c3b3d7&language=es-MX&page=${pagina}`
    );
    console.log(respuesta);
    if (respuesta.status === 200) {
      const datos = await respuesta.json();

      let peliculas = "";

      datos.results.forEach((pelicula) => {
        peliculas += `

            <div class="card">
            <img class="open-details-movie" id="${pelicula.id}" src="https://image.tmdb.org/t/p/w500/${pelicula.backdrop_path}">
			  <div class="titulo">
				<h4>${pelicula.original_title}</h4>
			  </div>
			</div>`;
      });

      document.getElementById("contenedor").innerHTML = peliculas;
    } else if (respuesta.status === 401) {
      console.log("colocaste la llave mal");
    } else if (respuesta.status === 404) {
      console.log("la pelicula no se incuentra");
    } else {
      console.log("error inesperado no se sabe cual es");
    }
  } catch (error) {
    console.log(error);
  }
};

cargarpelicula();
window.onload = function () {
  detallesPelicula(moveId);
  load.style.animation = "no alternate ease-in forwards"
  load.style.display = "none"
};
