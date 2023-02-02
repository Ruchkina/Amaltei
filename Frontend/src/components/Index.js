import React from "react";
import { Link } from 'react-router-dom';
import { Link as ScrollLink } from 'react-scroll';

import main from '../img/main.jpeg';

import SR from '../img/parties_icons/SR.png';
import ER from '../img/parties_icons/ER.png';
import KPRF from '../img/parties_icons/KPRF.png';
import LDPR from '../img/parties_icons/LDPR.png';
import NL from '../img/parties_icons/NL.png';
import NP from '../img/parties_icons/NP.png';
import Vi from '../img/Vibor.png';

const Index = () => {

    return (
        <React.Fragment>
            <div className="header">
                <img 
                    className="main_image" 
                    src={main}  
                    alt="Politikisto_main"
                />
                <p className="title"> Politikisto </p>
                <div className="description">
                    <h1>Choose your party</h1>
                    <p>
                        Любая политическая партия представляет какую-то часть общества, <br />
                        а защита и продвижение ее интересов становится основой политической деятельности.<br />
                        Узнайте, кто является электоратом действующих политических партий в РФ
                    </p>
                </div>
                <ScrollLink to='scroll-parties' spy={true} smooth={true} className="next">
                    <span>Поехали</span>
                    <div className="border"></div>
                </ScrollLink>
                <Link to='/about' className="about">О нас</Link>
            </div>

            <div id='scroll-parties' className="parties">
                <Link to='party/SpravedlivayRussia' className="SR">
                    <img src={SR} alt='Справедливая Россия' />
                    <p>Справедливая Россия</p>
                </Link>
                <Link to='party/EdinayRussia' className="ER" >
                    <img src={ER} alt='Единая Россия' />
                    <p>Единая Россия</p>
                </Link>
                <Link to='party/NewPeople' className="NL">
                    <img src={NL} alt='Новые люди' />
                    <p>Новые люди</p>
                </Link>
                <Link to='party/KPRF' className="KPRF">
                    <img src={KPRF} alt='КПРФ' />
                    <p>КПРФ</p>
                </Link>
                <Link to='party/NonParlament' className="NP">
                    <img src={NP} alt='Непарламентские партии' />
                    <p>Непарламентские партии</p>
                </Link>
                <Link to='party/LDPR' className="LDPR">
                    <img src={LDPR} alt='ЛДПР' />
                    <p>ЛДПР</p>
                </Link>
            </div>

            <div className="parties_title">
                <p>Выберите партию</p>
                <img src={Vi} alt='' />
            </div>

            <div className="description_parties">
                <div className="part">
                <p className="caption">
                    Справедливая Россия
                </p>
                <p className="text">
                    Левоцентристская политическая партия, придерживающаяся идеологии социал-демократии.
                    Основана 29 августа 2006 года в результате объединения нескольких партий
                </p>
                </div>

                <div className="part">
                <p className="caption">
                    Новые люди
                </p>
                <p className="text">
                    Политическая партия в России, образованная в Москве 1 марта 2020 года.
                    «Новые люди» считаются либеральной партией, и наблюдатели называют её центристской или правоцентристской
                </p>
                </div>

                <div className="part">
                <p className="caption">
                    Единая Россия
                </p>
                <p className="text">
                    Самая крупная проправительственная политическая партия Российской Федерации, считающаяся "партией власти".
                    Была учреждена 1 декабря 2001. Идеология партии – российский консерватизм
                </p>
                </div>

                <div className="part">
                <p className="caption">
                    ЛДПР
                </p>
                <p className="text">
                    Официально зарегистрированная политическая партия, с момента своего основания позиционирует себя как оппозиционная партия.
                    ЛДПР является прямой наследницей ЛДПСС, основана в 1992 году
                </p>
                </div>

                <div className="part">
                <p className="caption">
                    КПРФ
                </p>
                <p className="text">
                    Общероссийская политическая партия левого блока. Образована в 1993 году по инициативе коммунистов,
                    первичных организаций КП РСФСР и КПСС, являясь их идейным преемником
                </p>
                </div>

                <div className="part">
                <p className="caption">
                    Непарламентские партии
                </p>
                <p className="text">
                    Партии, не входящие в  Федеральное Собрание Российской Федерации.
                    Рассматривались такие партии, как “Яблоко”, “Коммунисты России”, “Пенсионеры”, “Партия роста”
                </p>
                </div>
            </div>

            <div>
                <p className="q1">„В детстве я хотел стать космонавтом, но надо было много учиться, поэтому я стал президентом“</p>
                <p className="q2">Джоржд Буш</p>
            </div>

            <footer>
                <div>
                    <p><a href="https://git.iu7.bmstu.ru/sgn3-prog/sgn3-prog-it-2022/it2022sgn-amaltheya/politikisto" className="transition">Amalteya</a> © BMSTU, SSH3; April, 2022 </p>
                </div>
            </footer>
        </React.Fragment>
    );
};

export default Index;