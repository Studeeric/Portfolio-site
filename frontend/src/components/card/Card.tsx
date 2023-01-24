import React, { useEffect, useState } from "react";
import packageInfo from './cards.json'
import '../../styles.css'

interface ICard {
    imagePath: string,
    title: string,
    subtext: string
}

const Card: React.FC = () => {
    const [card, setCard] = useState<ICard | null>();

    function changeCard() {
        var cardNumber = Math.floor(Math.random() * packageInfo.cards.length);
        setCard(packageInfo.cards[cardNumber])
    }

    useEffect(() => {
        changeCard()
    }, [])

    return (
        <div className="Card">
            <img className="Card__Image" src={card?.imagePath} alt="foto hier" />
            <h2 className="Card__Title">{card?.title}</h2>
            <p className="Card__Subtext">{card?.subtext}</p>
            <button className="Card__Button" onClick={changeCard}>Rerender</button>
        </div>
    )
}

export default Card;