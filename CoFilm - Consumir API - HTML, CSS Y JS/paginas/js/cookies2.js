document.body.addEventListener("click", (e) => {
  if (e.target.className == "open-details-serie") {
    e.preventDefault();
    let serieId = e.target.id;
    console.log(serieId);
    localStorage.setItem("serieId", serieId);
    window.open("./infoPelicula2.html","_self");
  }
});
