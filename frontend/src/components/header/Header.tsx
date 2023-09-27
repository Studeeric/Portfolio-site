import { Link } from "react-router-dom";

const items = [
    "Home",
    "Card",
    "Login"
]

const Header = () => {

    return (
        <div className="NavBar">
            <Link to="/"><img className="NavBar__Logo" src="/images/cardImages/SIM-logo.png" alt="Logo"/></Link>
            <div className="NavBar__List">
                {items.map((item) => (
                <Link key={item} className="NavBar__Item" to={item === 'Home' ? "/" : item}>{item}</Link>
                ))}
            </div>
        </div>
    )
}

export default Header;