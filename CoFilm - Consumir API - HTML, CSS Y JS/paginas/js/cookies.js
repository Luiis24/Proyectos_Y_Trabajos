document.body.addEventListener("click", (e) => {
  if (
    e.target.className == "open-details-movie" ||
    e.target.className == "open-details-movie poster"
  ) {
    console.log("sdf");
    e.preventDefault();
    let moveId = e.target.id;
    console.log(moveId);
    localStorage.setItem("moveId", moveId);
    window.open("./infoPelicula.html","_self");
  }
});
