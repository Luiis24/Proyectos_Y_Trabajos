let page = 1;

const btnBuscar = document.getElementById("btnBuscar");
const input = document.querySelector(".browser");
const paginador = document.querySelector(".paginacion");

btnBuscar.addEventListener("click", () => {
  if (input.value.trim() !== "") {
    page = 1;
    buscarPelicula();
  }
});

const crearBotonesPaginacion = (totalPages) => {
  paginador.innerHTML = "";

  for (let i = 1; i <= totalPages; i++) {
    console.log(i);
    const botonPagina = document.createElement("button");
    botonPagina.innerText = i;
    botonPagina.addEventListener("click", () => {
      page = i;
      buscarPelicula();
    });
    paginador.appendChild(botonPagina);
  }
  if (totalPages > 10) {
    paginador.classList.add("paginacion_largo");
  } else {
    paginador.classList.remove("paginacion_largo");
  }
};

const buscarPelicula = async () => {
  try {
    const respuesta = await fetch(
      `https://api.themoviedb.org/3/search/movie?api_key=3922568d95046025970a1b6575c3b3d7&query=${input.value.trim()}&page=${page}`
    );
    const datos = await respuesta.json();

    if (respuesta.status === 200) {
      let peliculas = "";
      datos.results.forEach((pelicula) => {
        let url = `https://image.tmdb.org/t/p/w500/${pelicula.poster_path}`;
        if (pelicula.poster_path === null) {
          url = "./img/error.png";
        }
        peliculas += `
          <div class="card">
            <img id="${pelicula.id}" class="open-details-movie poster" src="${url}">
            <div class="titulo">
              <h4>${pelicula.title}</h4>
            </div>
          </div> 
        `;
      });

      document.getElementById("contenedor").innerHTML = peliculas;

      crearBotonesPaginacion(datos.total_pages);
      console.log(datos.total_pages);
      btn_anterior.style.display = page > 1 ? "inline-block" : "none";
      btn_sgte.style.display =
        page < datos.total_pages ? "inline-block" : "none";
    } else if (respuesta.status === 401) {
      console.log("Colocaste la llave API incorrectamente");
    } else if (respuesta.status === 404) {
      console.log("La película no se encuentra");
    } else {
      console.log("Error inesperado. No se pudo obtener la información");
    }
  } catch (error) {
    console.log(error);
  }
};

input.addEventListener("keydown", async function(event) {
  if (event.key === "Enter") {
    event.preventDefault();
    await buscarPelicula();
  }
});
