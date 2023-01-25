import React from "react";
import { Link } from "react-router-dom";

const Header = () => {
    return (
        <div className="NavBar">
            <Link to="/"><img className="NavBar__Logo" src="/images/cardImages/SIM-logo.png" /></Link>
            <div className="NavBar__List">
                <Link className="NavBar__Item" to="/">Home</Link>
                <Link className="NavBar__Item" to="/card">Card</Link>
            </div>
        </div>
    )
}

export default Header;