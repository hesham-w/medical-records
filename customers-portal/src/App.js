import React from 'react';
import './App.css';
import ShoppingCart from './Components/OrderCart';

function App() {

  let products = [
    { name: 'Product A', id: 1 },
    { name: 'Product B', id: 2 },
    { name: 'Product C', id: 3 },
    { name: 'Product D', id: 4 }
  ]

  return (
    <div>
      <h1>Hello World</h1>
      <ShoppingCart orderedRecords={products}></ShoppingCart>
    </div>
  );
}

export default App;
