const sendfore = (event) =>{
    event.preventDefault()

    let nombre = event.target.nombre.value;
    let apellido = event.target.apellido.value;
    let select = event.target.opcion.value;
    let documento = event.target.documento.value;
    let archivo = event.target.archivo.value;
    let ficha = event.target.ficha.value;
    console.log(`Nombre ${nombre}`);
    console.log(`Apellido ${apellido}`);
    console.log(`Tipo de documento ${select}`);
    console.log(`Documento ${documento}`);
    console.log(`Archivo ${archivo}`);

    if(nombre == ""){
        alert('El campo "Nombre" está vacio')
    }else if (!isNaN(nombre)){
        alert('El campo "Nombre" no acepta números')
    }
    if(apellido == ""){
        alert('El campo "Apellido" está vacio')
    } else if(!isNaN(apellido)){
        alert('El campo "Apellido" no acepta números')
    }
    if(ficha == ""){
        alert('El campo "Ficha" está vacio')
    }
    if(documento == ""){
        alert('El campo "Documento" está vacio')
    }
    
}