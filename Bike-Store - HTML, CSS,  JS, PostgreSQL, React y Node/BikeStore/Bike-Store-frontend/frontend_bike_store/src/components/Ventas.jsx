import React, {useState, useEffect} from 'react'
import axios from 'axios';
import '../assets/css/ventas.css'
import ReactLoading from 'react-loading';
import { useLoading } from '../redux/loading';

export const Ventas = () => {
    const [ventas, setVentas] = useState([]);
    const {isLoading, setIsLoading} = useLoading()
    
  const getVentas = async () => {
    setIsLoading(true)
        axios.get('http://localhost:3000/ventas')
      .then(datos => {
          if(datos.data){
            setVentas(datos.data)
            setIsLoading(false)
          }
        console.log(datos.data)
      })
      .catch(error => {
        console.error('Error al obtener los datos:', error);
        setIsLoading(false)
      });
  }

  useEffect(() => {
    getVentas()
  }, []);

  const VentasCount = ventas.length; // Contador de Ventas

  if (VentasCount === 0) {
    return <div className='catalogo-vacio'>No Hay Ventas Registradas</div>;
  }


  return (
    <div className='containerVentas'>
      { isLoading ? <ReactLoading type="spin" color="#000" className='loading'/> : ''}
      
      
        <h2>Ventas: {VentasCount}</h2>
      {ventas[0] ? 
      <div className="container-tabla-ventas">
      <table className='tabla-compras' border="0">
      <tr className='headTC'>
        <th>ID</th>
        <th>Producto(s)</th>
        <th>Cantidad</th>
        <th>Cantidad Total</th>
        <th>Precio</th>
        <th>Cliente</th>
        <th>Fecha</th>
      </tr> 

      {ventas.map(venta => (
            <tr className='bodyTC' id={venta.idVenta}>
              <td>{venta.idVenta}</td>
              <td className='productosTC'>
                {venta.productos.map(producto => (
                <a href={`/detalles/${producto}`} >{producto}</a>
                ))}
              </td>
              <td className='cantidadTC'>
                {venta.cantidad.map(cantidad => (
                <p>{cantidad}</p>
                ))}
              </td>
              <td>{venta.cantidaProductos}</td>
              <td>${venta.total.toLocaleString('es-ES')}</td>
              <td>{venta.cliente}</td>
              <td>{venta.date}</td>
            </tr>
          
      ))} </table></div> : <div className='carrito-vacio'>No hay compras</div>}
    </div>
  )
}


  