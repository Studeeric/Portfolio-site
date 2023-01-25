import { render } from "@testing-library/react";
import React from "react";
import { Link } from "react-router-dom";

const items = [
    "Home",
    "Card",
    "Login"
]

const Header = () => {

    return (
        <div className="NavBar">
            <Link to="/"><img className="NavBar__Logo" src="/images/cardImages/SIM-logo.png" /></Link>
            <div className="NavBar__List">
                {items.map((item) => (
                <Link className="NavBar__Item" to={item === 'Home' ? "/" : item}>{item}</Link>
                ))}
            </div>
        </div>
    )
}

export default Header;