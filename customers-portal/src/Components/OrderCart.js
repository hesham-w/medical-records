import { Button, Drawer, List, ListItem } from '@mui/material'
import React from 'react';
import OrderCartLocation from './OrderCartLocation';

function ShoppingCart(props) {

  let { orderedRecords } = props;

  return (
    <div>
      <h1>Ordered Records</h1>
      {orderedRecords.map(orderedRecord => {
        return (
          <OrderCartLocation key={orderedRecord.id} location={orderedRecord} />
        );
      })}
    </div>
  );
}

export default ShoppingCart;