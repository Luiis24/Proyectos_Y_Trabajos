import React from 'react'

export const PrimerComponente = () => {
  return (
    <div>
    
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <a class="navbar-brand" href="#">Sena</a>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Perfil</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Noticias</a>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled">Ajustes</a>
        </li>
      </ul>
      <form class="d-flex" role="Buscar">
        <input class="form-control me-2" type="Buscar" placeholder="Buscar" aria-label="Buscar" />
        <button class="btn btn-outline-success" type="submit">Buscar</button>
      </form>
    </div>
  </div>
</nav>

    </div>
  )
}
