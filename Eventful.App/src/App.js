import logo from './logo.svg';
import './App.css';
import Header from './Components/Header';
import Footer from './Components/Footer';
import { useState, useEffect } from 'react';

function App() {
  const [events, setEvents] = useState()

  useEffect (() => {
    fetch('http://localhost:5276/api/events')
    .then(res => res.json())
    .then(data => setEvents(data))
  }, [])


  return (
    <div className="App">
      <h1>Events</h1>
      {events && events.map(event => (
        <div key={event.id}>
          <h2>{event.title}</h2>
          <p>{event.description}</p>
        </div>
      ))}
      
       <Header></Header>
       <Footer></Footer>
    </div>
  );
}

export default App;
