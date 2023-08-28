let pagina = 1;
let load = document.querySelector(".PreLoad")
const btnAnterior = document.getElementById('btnAnterior');
const btnSiguiente = document.getElementById('btnSiguiente');

load.style.display = "flex"
load.style.animation = "si alternate ease-in forwards"

btnSiguiente.addEventListener('click', () => {

    if (pagina < 2147483647) {
        pagina += 1;
        cargarpelicula();
    }
})
btnAnterior.addEventListener('click', () => {

    if (pagina > 1) {
        pagina -= 1;
        cargarpelicula();
    }
})

const recargar = document.querySelector(".NavLogo").addEventListener("click", () => {
    window.location = "./index.html";
})

var estado

const cargarpelicula = async () => {
    try {
        const respuesta = await fetch(`https://api.themoviedb.org/3/movie/popular?api_key=3922568d95046025970a1b6575c3b3d7&language=es-MX&page=${pagina}`);
        console.log(respuesta);
        if (respuesta.status === 200) {

            const datos = await respuesta.json();

            let peliculas = '';

            datos.results.forEach(pelicula => {
                peliculas += `

            <div class="card">
            <img class="open-details-movie" id="${pelicula.id}" src="https://image.tmdb.org/t/p/w500/${pelicula.poster_path}">
			  <div class="titulo">
				<h4>${pelicula.title}</h4>
			  </div>
			</div>`
            });
            document.getElementById('contenedor').innerHTML = peliculas;
        } else if (respuesta.status === 401) {
            console.log('colocaste la llave mal');
        } else if (respuesta.status === 404) {
            console.log('la pelicula no se incuentra');
        } else {
            console.log('error inesperado no se sabe cual es');
        }
    } catch (error) {
        console.log(error);
    }
}

cargarpelicula();
window.onload = function (){
    load.style.animation = "no .2s alternate ease-in forwards"
    load.style.display = "none"
}
