import React, { useState, useEffect } from 'react';
import './App.css';
import Filter from './Filter';
import Card from './Card';
import RandomButton from './RandomButton';

function App() {

  const [allListeners, setAllListeners] = useState([{id: 0 , colored: false , present: false, name: 'Wiktor Danielewski'}]);
  const [displayedListeners, setDisplayedListeners] = useState(allListeners);    // {attribute1: value1, attribute2: value2} -> utworzenie okiektu o danych atrybutach
  const [listenerName, setListenerName] = useState('');
  const [listenerID, setListenerID] = useState(1);
  const [enableAdd, setEnableAdd] = useState({text: 'Wprowadź dane słuchacza...',  enable: true});
  const [filters, setFilters] = useState([{checked: true}, {checked: false}, {checked: false}]);    // Tylko jeden filter w danym czasie może być ustawiony
  

  // useEffect jako argument przyjmuje funkcje. Jest to odpowiednik komponentu DidUpdate, DidMount (tylko przy starcie) zrobimy poprzez pozostawienie listy zależności pustej [].
  useEffect(() => {
    document.title = 'Liczba słuchaczy: ' + allListeners.length;
  }, [allListeners]) // [] <- lista zależności (dependecy list) - zamieszczamy w niej properties, zmiana property = wywołanie funckcji. Początkowo useEffect zawsze się wykonuje.



  //let task = '123'; -> wykorzystanie takiego sposobu przechowywania danych nie jest wskazane, ponieważ po update, który może zostać wykonany przez
  //kliknięcie przycisku 'Dodaj' (wywołanie setAllListeners())  wartość ta z powrotem jest ustawiana na '123' , a więc jeśli było coś wpisane to nie doda się to drugi raz tylko zostanie dodane '123'.


  // Funkcja losująca int'a z zakresu [min, max)
  function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min)) + min;
  }

//--------------------------------------------------------Handles------------------------------------------------------------
  // Uwaga: Zmienne mogą przechowywać funkcje


  // Obsłużenie zmiany danych w textbox
  const handleInput = function(event){
    setListenerName(event.target.value);
  };


// Dodanie nowego słuchacza 
  const handleClick = function(event){
    // Spread operator - tak jakby wyciągnięcie elementów z tablicy - pozbycie się:  [ ]
    const newListeners = [...allListeners, {id: listenerID, colored: false , present: false , name: listenerName}];

    // Aktualizacja listenerID - przydzielanego ID dla nowego słuchacza
    setListenerID(listenerID +1);

    // Aktualizacja tabel
    setDisplayedListeners(newListeners);
    setAllListeners(newListeners);
  };

  
  // Wylosowanie słuchacza
  const handleClickRandom = function(){
    // Czyszczenie zaznaczenia
    displayedListeners.map((x) => x.colored = false);

    // Wyznaczenie nowej tablicy z losowo wybranym słuchaczem
    const length = displayedListeners.length;

    // Jeśli nie jest pusta
    if (length != 0){
      const randomIndex = getRandomInt(0, length);
      const newArray = [...displayedListeners];
      newArray[randomIndex].colored = true;

      // Update
      setDisplayedListeners(newArray);

    }
  };


  // Odpowiedź na zmianę stanu checkbox'a odpowiedzialnego za sprawdzanie obecności (chcemy zmieniać parametr checked danego obiektu z tablicy wraz ze zmianą stanu checkbox'a)
  const handleChangePresence = function(listenerID){
    return (event) => {
      const newArray = [...allListeners];
      newArray[listenerID].present = event.target.checked;
      // Update
      setAllListeners(newArray);

    };

  }


  // Odpowiedź na zmianę stanu checkbox'a odpowiedzialnego za wyświetlenie wszystkich słuchaczy
  const handleChangeAll = function(){

    // Jeśli checkbox nie był zaznaczony
    if(filters[0].checked != true){
      
      // Ustawiamy wszystkie karty na niepokolorowane
      allListeners.map((x) => x.colored = false);
      // Aktualizujemy tablicę filters
      const newFilters = [{checked: true}, {checked: false}, {checked: false}];
      setFilters(newFilters);

      // Update
      const newArray = [...allListeners];
      setDisplayedListeners(newArray);
      setEnableAdd({text: 'Wprowadź dane słuchacza...', enable: true});
    }
  }



  // Odpowiedź na zmianę stanu checkbox'a odpowiedzialnego za wyświetlenie tylko obecnych słuchaczy
  const handleChangeOnlyPresent = function(){

    // Jeśli checkbox nie był zaznaczony
    if(filters[1].checked != true){

      // Ustawiamy wszystkie karty na niepokolorowane
      allListeners.map((x) => x.colored = false);
      // Aktualizujemy tablicę filters
      const newFilters = [{checked: false}, {checked: true}, {checked: false}];
      setFilters(newFilters);

      // Tworzymy nową tablicę składającą się tylko z obecnych słuchaczy
      const newArray = allListeners.filter( (elementFromTable) => {
        return elementFromTable.present == true;
      });

      // Update
      setDisplayedListeners(newArray);
      setEnableAdd({text: 'Zablokowane...', enable: false});
    }
  }

  // Odpowiedź na zmianę stanu checkbox'a odpowiedzialnego za wyświetlenie tylko nieobecnych słuchaczy
  const handleChangeOnlyAbsent = function(){

    // Jeśli checkbox nie był zaznaczony
    if(filters[2].checked != true){

      // Ustawiamy wszystkie karty na niepokolorowane
      allListeners.map((x) => x.colored = false);
      // Aktualizujemy tablicę filters
      const newFilters = [{checked: false}, {checked: false}, {checked: true}];
      setFilters(newFilters);

      // Tworzymy nową tablicę składającą się tylko z nieobecnych słuchaczy
      const newArray = allListeners.filter( (elementFromTable) => {
        return elementFromTable.present == false;
      });

      // Update
      setDisplayedListeners(newArray);
      setEnableAdd({text: 'Zablokowane...', enable: false});
    }
    
  }

//---------------------------------------------------------------------------------------------------------------------------





  return (
    <div className="App">

      <header className="App-header"> Lista obecności</header>

      <div>
        
        <input className='input' value={enableAdd.enable ? listenerName.name : ''} placeholder= {enableAdd.text} disabled={!enableAdd.enable} onInput={handleInput}/>
        <button className='btn' disabled={!enableAdd.enable} onClick={handleClick}>Dodaj słuchacza</button>

        <div className='App-subsection-header'>Filtry:</div>

        <div className='containerv2'>
          <Filter filterName = {'Wszyscy:'} checked={filters[0].checked} onChange = {handleChangeAll} />
          <Filter filterName = {'Obecni:'} checked={filters[1].checked} onChange = {handleChangeOnlyPresent} />
          <Filter filterName = {'Nieobecni:'} checked={filters[2].checked} onChange = {handleChangeOnlyAbsent} />     
        </div>

        <RandomButton className = {'focus'} onClick ={handleClickRandom} text={'Wylosuj słuchacza'}/>

        <div className='container'>
          {displayedListeners.map(function(elementFromTable){
            return(
              <Card colored = {elementFromTable.colored} key = {elementFromTable.id} id = {elementFromTable.id} name = {elementFromTable.name} checked={elementFromTable.present} onChange = {handleChangePresence(elementFromTable.id)}/>
            );
            
          })}
        </div>

      </div>

    </div>
  );
}

export default App;
