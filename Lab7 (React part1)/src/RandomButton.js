import React from "react";


function RandomButton(props){

    //className
    //onClick
    //text
    return (

        <>
        <button className= {props.className} onClick={props.onClick}>{props.text}</button>
        </>
    );
    
}

export default RandomButton;