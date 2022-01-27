import React from "react";

export default function OrderCartLocation(props) {

    let { location } = props;

    return (
        <div>
            <span style={{ fontWeight: 'bold' }}>{location.name}</span>
        </div >
    );

}