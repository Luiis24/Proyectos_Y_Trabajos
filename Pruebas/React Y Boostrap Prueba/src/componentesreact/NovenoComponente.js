import React from 'react'

export const NovenoComponente = () => {
  return (
    <div>
        <div id="carouselExampleCaptions" class="carousel slide">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://pbs.twimg.com/media/DdDIISbXUAECrr0.jpg" class="d-block w-100" alt="..." />
    </div>
    <div class="carousel-item">
      <img src="https://www.sena.edu.co/es-co/Noticias/PublishingImages/Lists/Noticias/Histrico%20Noticias/Aprendices_05032021.jpeg" class="d-block w-100" alt="..." />
    </div>
    <div class="carousel-item">
      <img src="https://pbs.twimg.com/media/Dc7IntoXkAAvWgr?format=jpg&name=large" class="d-block w-100" alt="..." />
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev" >
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
    </div>
  )
}
