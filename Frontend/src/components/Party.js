/* eslint-disable no-undef */
import React, { useState, useEffect } from "react";
import { useParams, useNavigate, Link } from "react-router-dom";
import axios from 'axios';
import main from '../img/main.jpeg';
import portrait from '../img/portrait_man.png';
import Vi from '../img/Vibor.png';
import lArrow from '../img/l_arrow.PNG';
import rArrow from '../img/r_arrow.PNG';

const graphNames = ['graphAge', 'graphLifeMain', 'graphPolitical', 'graphGender', 'graphCity', 'graphRelation', 'graphEducation'];
const graphNamesForPage = [
    'Соотношение возрастов в социальной базе партии',
    'Количество людей, разделяющие определенные жизненные ценности',
    'Количество людей, разделяющие определенные полтические взгляды',
    'Соотношение мужчин и женщин в социальной базе партии',
    'Распределение представителей электората по городам России',
    'Семейное положение представителей социальной базы партии',
    'Образование представителей социальной базы партии'
]

const data = {
    LDPR:{"about":{"name":"ЛДПР","description":"Официально зарегистрированная политическая партия, с момента своего основания позиционирует себя как оппозиционная партия. ЛДПР является прямой наследницей ЛДПСС, основана в 1992 году."}},
    KPRF:{"about":{"name":"КПРФ","description":"Общероссийская политическая партия левого блока. Образована в 1993 году по инициативе коммунистов, первичных организаций КП РСФСР и КПСС, являясь их идейным преемником."}},
    NonParlament:{"about":{"name":"Непарламентские партии","description":"Партии, не входящие в  Федеральное Собрание Российской Федерации. Рассматривались такие партии, как \“Яблоко\”, \“Коммунисты России\”, \“Пенсионеры\”, \“Партия роста\”."}},
    EdinayRussia:{"about":{"name":"Единая Россия","description":"Самая крупная проправительственная политическая партия Российской Федерации, считающаяся \"партией власти\". Была учреждена 1 декабря 2001. Идеология партии – российский консерватизм."}},
    SpravedlivayRussia:{"about":{"name":"Справедливая Россия","description":"Левоцентристская политическая партия, придерживающаяся идеологии социал-демократии. Основана 29 августа 2006 года в результате объединения нескольких партий."}},
    NewPeople:{"about":{"name":"Новые люди","description":"Политическая партия в России, образованная в Москве 1 марта 2020 года. \«Новые люди\» считаются либеральной партией, и наблюдатели называют её центристской или правоцентристской."}},
}

const Party = () => {
    const { partyId } = useParams();
    const navigate = useNavigate();

    const [pageIsTop, setPageIsTop] = useState(false);
    const [party, setParty] = useState({});
    const [grpahIndex, setGraphIndex] = useState(0);

    useEffect(() => {
        if (!pageIsTop) {
            setPageIsTop(!pageIsTop);
            document.documentElement.scrollTo({
                top:0, 
                left:0,
                behavior: 'smooth'});
        }
    });

    useEffect(() => {
        if (Object.keys(party).length === 0) getParty();
        else {
            google.load("visualization", "1", {packages:["corechart"]});
            google.setOnLoadCallback(drawChart);
            function drawChart() {
                let dataAsArray = [];
                const currentGraph = party[graphNames[grpahIndex]];
                switch (graphNames[grpahIndex]) {
                    case 'graphAge':
                        dataAsArray = [
                            ['Возраст',         'Соотношение'],
                            ['Менее 20 лет',    currentGraph?.less20Age],
                            ['От 20 до 30 лет', currentGraph?.between20_30Age],
                            ['От 30 до 40 лет', currentGraph?.between30_40Age],
                            ['От 40 до 60 лет', currentGraph?.between40_60Age],
                            ['От 60 лет',       currentGraph?.over60]
                        ];
                        break;
                    case "graphLifeMain":
                        dataAsArray = [
                            ['Главное в жизни',       'Соотношение'],
                            ['Семья',                 currentGraph.family],
                            ['Карьера и деньги',      currentGraph.careerMoney],
                            ['Известность и власть',  currentGraph.famePower],
                            ['Развлечения',           currentGraph.entertainment],
                            ['Наука и знания',        currentGraph.science],
                            ['Саморазвитие',          currentGraph.selfDevelopment]
                        ];
                        break;
                    case "graphPolitical":
                        dataAsArray = [
                            ['Политические взгляды', 'Соотношение'],
                            ['Коммунистические',    currentGraph.communists],
                            ['Социалистические',    currentGraph.socialists],
                            ['Умеренные',           currentGraph.moderate],
                            ['Либеральные',         currentGraph.liberals],
                            ['Консервативные',      currentGraph.conservatives],
                            ['Не определившиеся',   currentGraph.indifferents]
                        ];
                        break;
                    case "graphGender":
                        dataAsArray = [
                            ['Пол',     'Соотношение'],
                            ['Мужчины', currentGraph.man],
                            ['Женщины', currentGraph.woman]
                        ];
                        break;
                    case "graphCity":
                        dataAsArray = [
                            ['Город', 'Соотношение'],
                        ];
                        currentGraph.cityDtos.map(city => dataAsArray.push([city.name, city.value]))
                        break;
                    case "graphRelation":
                        dataAsArray = [
                            ['Семейное положение',  'Соотношение'],
                            ['В браке',             currentGraph.married],
                            ['Не состоят в браке',  currentGraph.notMarried],
                            ['Есть друг',           currentGraph.haveFriend],
                            ['В гражданском браке', currentGraph.civilMerriage],
                            ['Помолвлены',          currentGraph.engagement],
                            ['В активном поиске',   currentGraph.activeResearch]
                        ];
                        break;
                    case "graphEducation":
                        dataAsArray = [
                            ['Образование', 'Соотношение'],
                            ['Высшее',      currentGraph.university],
                            ['Работают',    currentGraph.work],
                            ['Среднее',     currentGraph.school],
                        ];
                        break;
                    default:
                        break;
                }

                const data = google.visualization.arrayToDataTable(dataAsArray);
                const options = {
                    title: '',
                    is3D: false,
                    pieResidueSliceLabel: 'Остальное',
                    colors: ['#90bacd','#5997b0', '#98ccd6', '#6cb6eb', '#5e9bdb', '#88bcf2'],
                    backgroundColor: '#3d5367',
                    legend: {
                        textStyle: {
                            color: 'white',
                            fontName: 'Cormorant Garamond'
                        }
                    }
                };
                const chart = new google.visualization.PieChart(document.getElementById('air'));
                chart.draw(data, options,);
            }
        }
    }, [party, grpahIndex]);

    const getPolitical = (political) => {
        switch (political) {
            case 'liberals':
                return 'Либеральные';
            case 'communists':
                return 'Коммунистические';
            case 'conservatives':
                return 'Консервативные';
            case 'moderate':
                return 'Умеренные';
            case 'socialists':
                return 'Социалистические';
            default:
                return 'ERROR';
        }
    }

    const getLifeMain = (lifeMain) => {
        switch (lifeMain) {
            case 'famaly':
                return 'Семья';
            case 'famaly/entertainment':
                return 'Семья и развлечения';
            case 'self_development/science':
                return 'Саморазвитие и наука';
            case 'self_development/fame_power':
                return 'Саморазвитие и слава';
            case 'famaly/career_money':
                return 'Семья и карьера';
            case 'famaly/science':
                return 'Семья и наука';
            default:
                return 'ERROR';   
        }
    }
 
    const getRelation = (relation) => {
        switch (relation) {
            case 'married':
                return 'В браке';
            case 'not_married':
                return 'Не в браке';
            case 'haveFriend':
                return 'Есть друг';
            case 'civilMerriage':
                return 'В гражданском браке';
            case 'engagement':
                return 'Помолвлены';
            case 'activeResearch':
                return 'в активном поиске';
            default:
                return 'ERROR';
        }

    }

    const getParty = () => {
        axios.get(`https://localhost:5001/party/${partyId}`, {withCredential: true})
            .then(response => {
                console.log(response)
                const dataOfBackend = response.data;
                setParty({
                    ...dataOfBackend,
                    "about":{
                        "name": data[partyId].about.name,
                        "description": data[partyId].about.description
                    },
                    "portrait":{
                        "sex": dataOfBackend.portrait.sex === 'W' ? 'Женщина' : 'Мужчина',
                        "occupation": dataOfBackend.portrait.occupation === 'university' ? 'Высшее' : 'Среднее',
                        "lifeMain": getLifeMain(dataOfBackend.portrait.lifeMain),
                        "relation": getRelation(dataOfBackend.portrait.relation),
                        "political": getPolitical(dataOfBackend.portrait.political),
                        "city": dataOfBackend.portrait.city,
                        "age": dataOfBackend.portrait.age
                    }
                });
            })
            .catch(error => console.log(error));
    };

    const changeGraph = (event) => {
        console.log(party)
        const arrowImgClassName = event.target.className;
        if (arrowImgClassName === 'larim') {
            setGraphIndex(i => i === 0 ? graphNames.length-1 : --i);
        }
        else if (arrowImgClassName === 'rarim') {
            setGraphIndex(i => i === graphNames.length-1 ? 0 : ++i);
        }
        else {
            alert('Скорее всего было изменено название класса стрелки, обновите его в changeGraph функции.');
        }
    }

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
                <h1>{party.about?.name}</h1>
                <p>{party.about?.description}</p>
                </div>
                <button onClick={() => navigate(-1)} className="next next_party">Назад</button>
                <Link to='/about' className="about">О нас</Link>
            </div>

            <div className="party_description_1">
                <img src={portrait} alt='' />
            </div>

            <div className="party_params">
                <div className="param1">
                    <p className="title">Образование</p>
                    <p className="description">{party.portrait?.occupation}</p>
                </div>
                <div className="param2">
                    <p className="title">Место проживания</p>
                    <p className="description">{party.portrait?.city}</p>
                </div>
                <div className="param3">
                    <p className="title">Семейное положение</p>
                    <p className="description">{party.portrait?.relation}</p>
                </div>
                <div className="param4">
                    <p className="title">Пол</p>
                    <p className="description">{party.portrait?.sex}</p>
                </div>
                <div className="param5">
                    <p className="title">Возрастная группа</p>
                    <p className="description">{party.portrait?.age} лет</p>
                </div>
                <div className="param6">
                    <p className="title">Политические взгляды</p>
                    <p className="description">{party.portrait?.political}</p>
                </div>
                <div className="param7">
                    <p className="title">Главное в жизни</p>
                    <p className="description">Семья</p>
                </div>
            </div>

            <div className="parties_title">
                <p>{party.about?.name}</p>
                <img src={Vi} />
            </div>

            <div className="party_description_2">
                <p className="title">{party.about?.name}</p>
                <p className="description">{graphNamesForPage[grpahIndex]}</p>
                <div id="air"></div>
                <button className="arrow larrow" onClick={changeGraph}><img className="larim" src={lArrow} alt='Стрелка влево'/></button>
                <button className="arrow rarrow" onClick={changeGraph}><img className="rarim" src={rArrow} alt='Стрелка вправо'/></button>
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

export default Party;
