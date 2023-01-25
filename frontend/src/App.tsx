import React from 'react';
import logo from './logo.svg';
import Card from './components/card/Card';
import AppRouter from './components/routing/AppRouter';
import Home from './components/home/Home';
import Header from './components/header/Header';

function App() {
  return (
    <div>
      <Header/>
      <AppRouter/>
    </div>
  );
}

export default App;
