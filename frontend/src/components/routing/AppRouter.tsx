import { Routes, Route } from 'react-router-dom';
import Home from "../home/Home";
import Card from "../card/Card";
import Login from "../login/Login";

const AppRouter = () => {
    return (         
        <Routes>
        <Route path='/' element={<Home/>} />
        <Route path='/Card' element={<Card/>} />
        <Route path='/Login' element={<Login/>} />
      </Routes>
    )
}

export default AppRouter;