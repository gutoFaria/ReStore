import { useEffect, useState } from "react";
import { Product } from "../../app/models/products";
import ProductList from "./ProductList";

// interface Props{
//     products: Product[];
//     addProduct: () => void;
// }

export default function Catalog(){
    const [products,setProducts] = useState<Product[]>([]);

  useEffect(() =>{
    fetch('https://localhost:7282/api/products')
      .then(response => response.json())
      .then(data => setProducts(data))
  },[])

//   function addProducts(){
//     setProducts(prevState => [...prevState,
//       {
//         id: prevState.length * 101,
//         name:'peoduct'+prevState.length,
//         descrition:'some description',
//         price:(prevState.length * 100),
//         brand: 'some brand',
//         pictureUrl:'http://picsum.photos/200',
//       }
//     ])
//   }
    return(
        <>
           <ProductList  products={products}/>
      
        </>
    )
}