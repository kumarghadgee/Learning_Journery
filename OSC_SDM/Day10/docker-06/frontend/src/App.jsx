import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import { useEffect } from 'react'
import axios from 'axios'

function App() {
  const [products, setProducts] = useState([])
  const [errMessage, setErrMessage] = useState(null)
  //const url = "http://localhost:3000/products"
  const url = "/api/products"
  useEffect(() => {
    axios
      .get(url)
      .then((response) => {
        const resp = response.data
        if(resp.status === "success") 
          setProducts(resp.result)
        else
          console.log("ERROR: " + resp.message)
      })
      .catch((err) => {
        const message = `${err.name}: ${err.message}`
        console.log("ERROR: " + message)
      })
  }, [])

  return (
    <>
      <h3>Products</h3>
      {errMessage !== null && <div>{errMessage}</div>}
      {products.map((item) => (
        <p key={item.id}>{item.id} - {item.name} - {item.price}</p>
      ))}
    </>
  )
}

export default App
