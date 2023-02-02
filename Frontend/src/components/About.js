import React from "react";
import { useNavigate } from 'react-router-dom';
import { useEffect } from "react";
import main from '../img/main.jpeg';
import cat from '../img/cat.png';
import fox from '../img/fox.png';
import rabbit from '../img/rabbit.png';


const About = () => {
  const navigate = useNavigate();

  useEffect(() => document.documentElement.scrollTo({
    top:0, 
    left:0,
    behavior: 'smooth'}));
  
  return (
    <React.Fragment>
      <div className="header header_short">
        <img
          className="main_image"
          src={main}
          alt="Politikisto_main"
        />
        <p className="title"> Politikisto </p>

          <button onClick={() => navigate(-1)} className="about">Назад</button>
        </div>

        
      <div className="work_project">
          <h3 className="h-about">Учебный проект по дисциплине “Интернет-технологии”</h3>
          <h3 className="h-about">Действующие лица:</h3>
      </div>

      <div className="faces">
        <img src={cat}/>
        <div className="face">
            <p className="name">Анастасия Ручкина</p>
            <p className="face_about">
              Студентка второго курса МГТУ им. Н.Э. Баумана,<br />
              СГН3-43Б.<br />
              Роль - бэкенд-разработчик. Тащит весь код, хоть у нее и лапки.</p>
        </div>
        <img src={fox}/>
        <div className="face">
            <p className="name">Полина Кравец</p>
            <p className="face_about">
              Студентка второго курса МГТУ им. Н.Э. Баумана,<br />
              СГН3-44Б.<br />
              Роль - фронтенд-разработчик. Но, как вы видите по этому дизайну, не все печально.</p>
        </div>
        <img src={rabbit}/>
        <div class="face">
            <p class="name">Мария Сташук</p>
            <p class="face_about">
              Студентка второго курса МГТУ им. Н.Э. Баумана,<br />
              СГН3-43Б.<br />
              Роль - аналитик. Шаманит с данными, графиками, и не только.</p>
        </div>
      </div>
      <div class="description_parties description_faces">
        <div class="part">
          <p class="caption">
            Что мы хотели проверить
          </p>
          <p class="text">
            Электорат каждой из рассматриваемых политических партий по-своему уникален,
                поэтому его изучение и исследование дает возможность партиям более “точечно” проводить
                свои предвыборные кампании и лучшим образом отражать интересы представителей своей социальной базы.
          </p>
        </div>

        <div class="part">
          <p class="caption">
            Что для этого было сделано
          </p>
          <p class="text">
            Через поиск по группам ВК была найдена информация о подписчиках представленных партий, которая с помощью публичного API-ключа была выгружена согласно рассматриваем метрикам. <br />
                Далее полученный датасет был формализован, и с помощью дескриптивного и частотного анализа был составлен алгоритм по “составлению” портрета.<br />
                Итоговый результат был представлен в виде SPA.
          </p>
        </div>

        <div class="part">
          <p class="caption">
            Раз вы это читаете, значит все успешно :)
          </p>
        </div>
      </div>

      <div class="quote quote_about">
        <p class="q1">„В детстве я хотел стать космонавтом, но надо было много учиться, поэтому я стал президентом“</p>
        <p class="q2">Джоржд Буш</p>
      </div>

      <footer class="footer_about">
          <div>
              <p><a href="https://git.iu7.bmstu.ru/sgn3-prog/sgn3-prog-it-2022/it2022sgn-amaltheya/politikisto" class="transition">Amalteya</a> © BMSTU, SSH3; April, 2022 </p>
          </div>
      </footer>
    </React.Fragment>
  );
};

export default About;
