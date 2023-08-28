import React from 'react'

export const SegundoComponente = () => {
  return (
    <div>
        <div id="carouselExampleAutoplaying" class="carousel slide" data-bs-ride="carousel">
    <div class="carousel-inner">
      <div class="carousel-item active">
        <img src="https://www.sena.edu.co/es-co/comunidades/instructores/PublishingImages/Paginas/Banco_Instructores_2023/Bot%C3%B3n%20dentro%20del%20micrositio.jpg" class="d-block w-100" height="230px" />
      </div>
      <div class="carousel-item">
        <img src="https://www.sena.edu.co/es-co/Noticias/RotaBannerImg/BANNER-CAMPESENA-PUNTO322022023.jpg" class="d-block w-100" height="230px" />
      </div>
      <div class="carousel-item">
        <img src="https://www.sena.edu.co/es-co/Noticias/RotaBannerImg/Formacion-03102023.png" class="d-block w-100" height="230px" />
      </div>
    </div>
    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
      <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
      <span class="visually-hidden">Next</span>
    </button>
  </div>
    </div>
  )
}
