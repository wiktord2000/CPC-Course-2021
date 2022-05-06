import React from "react";


function Filter(props){

    //filterName
    //checked
    //onChange
    return (

        <>
        <div className='mediumFont'>{props.filterName}</div><input type='checkbox' className='right-margin' checked= {props.checked} onChange={props.onChange}/>
        </>
    );
    
}

export default Filter;