import React from "react";


function Card(props){

    //colored
    //id
    //key
    //name
    //checked
    //onChange
    return (

        <>
        <div className= {props.colored ? 'selectedCard' : 'card'} >
        {props.id + 1} . {props.name}   
        <input type='checkbox' checked={props.checked} onChange = {props.onChange}/>
        </div>
        </>
    );
    
}

export default Card;