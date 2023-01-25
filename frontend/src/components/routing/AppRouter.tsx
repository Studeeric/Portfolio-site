import React from "react";
import { Routes, Route } from 'react-router-dom';
import Home from "../home/Home";
import Card from "../card/Card";

const AppRouter = () => {
    return (         
        <Routes>
        <Route path='/' element={<Home/>} />
        <Route path='/Card' element={<Card/>} />
      </Routes>
    )
}

export default AppRouter;