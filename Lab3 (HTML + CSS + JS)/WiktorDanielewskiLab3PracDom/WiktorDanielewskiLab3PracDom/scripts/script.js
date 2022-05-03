
let potatoPrice = 3.00;
let carrotPrice = 4.00;


/*Funkcja, która jest wywoływana przy każdej zmianie wartości pola "quantityOfPotato" - na jego podstawie oblicza wartść pola "totalPotatoPrice"*/
function PotatoCountPrice() {

    let actualQuantity = parseFloat(document.getElementById('quantityOfPotato').value);
    let actualPrice = actualQuantity * potatoPrice;
    document.getElementById('totalPotatoPrice').value = actualPrice.toFixed(2);
}

/*Funkcja, która jest wywoływana przy każdej zmianie wartości pola "totalPotatoPrice" - na jego podstawie oblicza wartść pola "quantityOfPotato"*/
function PotatoCoundQuantity() {

    let actualPrice = parseFloat(document.getElementById('totalPotatoPrice').value);
    let actualQuantity = (actualPrice / potatoPrice);
    document.getElementById('quantityOfPotato').value = actualQuantity.toFixed(2);

}


/*Funkcja, która jest wywoływana przy każdej zmianie wartości pola "quantityOfCarrot" - na jego podstawie oblicza wartść pola "totalCarrotPrice"*/
function CarrotCountPrice() {

    let actualQuantity = parseFloat(document.getElementById('quantityOfCarrot').value);
    let actualPrice = actualQuantity * carrotPrice;
    document.getElementById('totalCarrotPrice').value = actualPrice.toFixed(2);
}

/*Funkcja, która jest wywoływana przy każdej zmianie wartości pola "totalCarrotPrice" - na jego podstawie oblicza wartść pola "quantityOfCarrot"*/
function CarrotCoundQuantity() {

    let actualPrice = parseFloat(document.getElementById('totalCarrotPrice').value);
    let actualQuantity = (actualPrice / carrotPrice);
    document.getElementById('quantityOfCarrot').value = actualQuantity.toFixed(2);

}













function AddPotato() {
    sessionStorage.setItem('potato', 'Ziemniaki');
    sessionStorage.setItem('quantityOfPotatos', document.getElementById('quantityOfPotato').value);
    sessionStorage.setItem('totalPotatoPrice', document.getElementById('totalPotatoPrice').value);
}

function AddCarrot() {
    sessionStorage.setItem('carrot', "Marchew");
    sessionStorage.setItem('quantityOfCarrot', document.getElementById('quantityOfCarrot').value);
    sessionStorage.setItem('totalCarrotPrice', document.getElementById('totalCarrotPrice').value);
}




/*Funkcja wykonująca się po naciśnięciu przycisku 'Wyczyść koszyk'*/
function ClearShoppingCard() {

    sessionStorage.clear();
    document.getElementById('productsTable').innerHTML =
        '<tr>' +
        '<th> Product name </th>' +
        '<th> Quantity </th>' +
        '<th> Price </th>' +
        '</tr>';
}


function RefreshProductsTable() {

    /*Usunięcie treści*/
    document.getElementById('productsTable').innerHTML = "";

    /*Dodanie nazw kolumn*/
    document.getElementById('productsTable').innerHTML +=
        '<tr>' +
        '<th> Product name </th>' +
        '<th> Quantity </th>' +
        '<th> Price </th>' +
        '</tr>';

    
    
    /*for (let i = 0; i < sessionStorage.length / 3; i++) {

        document.getElementById('productsTable').innerHTML +=
            '<tr>' +
                '<td> ' + sessionStorage.getItem(sessionStorage.key(i)) + '</td>' +
                '<td> ' + sessionStorage.getItem(sessionStorage.key(i + 1)) + '</td>' +
                '<td> ' + sessionStorage.getItem(sessionStorage.key(i + 2)) + '</td>' +
            '</tr>';
    }*/

    /*Dodanie wierszy*/
    document.getElementById('productsTable').innerHTML +=
        '<tr>' +
            '<td> ' + sessionStorage.getItem('potato') + '</td>' +
            '<td> ' + sessionStorage.getItem('quantityOfPotatos') + '</td>' +
            '<td> ' + sessionStorage.getItem('totalPotatoPrice') + '</td>' +
        '</tr>'+
        '<tr>' +
            '<td> ' + sessionStorage.getItem('carrot') + '</td>' +
            '<td> ' + sessionStorage.getItem('quantityOfCarrot') + '</td>' +
            '<td> ' + sessionStorage.getItem('totalCarrotPrice') + '</td>' +
        '</tr>';

    
    

}
