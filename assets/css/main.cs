* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  text-decoration: none;
  list-style: none;
  color: inherit;
  font-family: "Roboto", sans-serif;
  font-family: "Nerko One", cursive;
}

.container {
  width: 80%;
  margin: 0 auto;
}

.header {
  background: #FCEED5;
  position: relative;
}
.header .belgi {
  position: absolute;
  top: 0px;
  left: 0;
  width: 500px;
  z-index: 1;
}
.header .kok {
  position: absolute;
  bottom: 150px;
  left: 700px;
  width: 300px;
  z-index: 1;
}
.header .sariq {
  position: absolute;
  bottom: 55px;
  left: 700px;
  width: 500px;
  z-index: 18;
}
.header .mayda {
  position: absolute;
  bottom: 500px;
  left: 750px;
  width: 30px;
  z-index: 18;
}
.header .mayda1 {
  position: absolute;
  bottom: 450px;
  left: 750px;
  width: 25px;
  z-index: 18;
}
.header .mayda2 {
  position: absolute;
  bottom: 500px;
  left: 800px;
  width: 20px;
  z-index: 18;
}
.header .container .nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 30px 0px;
  z-index: 90;
}
.header .container .nav__logo {
  z-index: 60;
}
.header .container .nav__list {
  display: flex;
  gap: 25px;
  padding: 0;
  margin: 0;
}
.header .container .nav__list__item a {
  font-size: 20px;
  color: #001a4d;
  padding: 3px 0px;
  border-bottom: 2px solid transparent;
  font-weight: 700;
}
.header .container .nav__list__item a:hover {
  color: #FCC647;
  text-decoration: none;
  border-color: #FCC647;
}
.header .container .nav__list__btn1 {
  background-color: white;
  padding: 10px 15px;
  border-radius: 50px;
  font-weight: 500;
  color: grey;
}
.header .container .nav__list__btn2 {
  background-color: white;
  padding: 10px 15px;
  border-radius: 50px;
  background-color: #001a4d;
  color: white;
  font-weight: 700;
}
.header .container .nav #check {
  display: none;
}
.header .container .nav .open {
  font-size: 23px;
  display: none;
  color: black;
}
.header .container .nav .close {
  font-size: 28px;
  display: none;
  z-index: 4;
  color: black;
}
.header .container .nav .close1 {
  position: fixed;
  width: 100%;
  height: 100vh;
  top: 0;
  z-index: 2;
  left: 0;
  display: none;
}
@media (max-width: 1110px) {
  .header .belgi {
    display: none;
    position: absolute;
    top: 0px;
    left: 0;
    width: 500px;
    z-index: 1;
  }
  .header .kok {
    display: none;
    position: absolute;
    bottom: 0px;
    left: 700px;
    width: 300px;
    z-index: 1;
  }
  .header .sariq {
    display: none;
    position: absolute;
    bottom: -100px;
    left: 700px;
    width: 500px;
    z-index: 18;
  }
  .header .mayda {
    display: none;
    position: absolute;
    bottom: 400px;
    left: 750px;
    width: 30px;
    z-index: 18;
  }
  .header .mayda1 {
    display: none;
    position: absolute;
    bottom: 450px;
    left: 750px;
    width: 25px;
    z-index: 18;
  }
  .header .mayda2 {
    display: none;
    position: absolute;
    bottom: 500px;
    left: 800px;
    width: 20px;
    z-index: 18;
  }
  .header .container .nav__list__btn1, .header .container .nav__list__btn2 {
    display: none;
  }
}
@media (max-width: 776px) {
  .header .container .nav__list {
    z-index: 95;
    position: fixed;
    top: 0;
    left: -100%;
    width: 70%;
    height: 100vh;
    background: grey;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    transition: 1s;
  }
  .header .container .nav__list__btn1, .header .container .nav__list__btn2 {
    display: block;
  }
  .header .container .nav .close1 {
    left: -100%;
    display: block;
    transition: 0.4s;
  }
  .header .container .nav .open {
    display: block;
  }
  .header .container .nav #check:checked + .nav__list {
    left: 0;
  }
  .header .container .nav #check:checked ~ .open {
    display: none;
  }
  .header .container .nav #check:checked ~ .close {
    display: block;
  }
  .header .container .nav #check:checked ~ .close1 {
    left: 0;
  }
  .header .container .nav .dropdown {
    display: none;
  }
}
@media (max-width: 450px) {
  .header .container .nav__logo {
    width: 60%;
  }
  .header .container .nav__logo a img {
    width: 100%;
  }
  .header .container .nav .open {
    font-size: 20px;
  }
  .header .container .nav .close {
    font-size: 24px;
  }
  .header .container .nav__list {
    row-gap: 10px;
  }
  .header .container .nav__list__item a {
    font-size: 18px;
  }
}
.header .showcase {
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 100%;
  padding: 50px 0px;
}
.header .showcase__left {
  width: 50%;
  padding-left: 10%;
  position: relative;
}
.header .showcase__left .one {
  font-size: 55px;
  word-spacing: 15px;
}
.header .showcase__left h2 {
  color: #001a4d;
}
.header .showcase__left h2 {
  font-size: 48px;
  width: 100%;
  padding: 10px 0px;
  margin: 0;
}
.header .showcase__left__text {
  font-size: 16px;
  padding-bottom: 20px;
  color: #001a4d;
}
.header .showcase__left__matn {
  display: flex;
  column-gap: 20px;
  align-items: center;
}
.header .showcase__left__matn img {
  height: 20px;
}
.header .showcase__left__matn a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: inherit;
  background-color: transparent;
  z-index: 10;
  border: 1px solid blue;
  padding: 10px 30px;
}
.header .showcase__left__matn a:hover {
  background: grey;
  color: white;
  text-decoration: none;
}
.header .showcase__left__matn a:nth-child(1) {
  color: blue;
  background: transparent;
}
.header .showcase__left__matn a:nth-child(1):hover {
  background: grey;
  color: white;
}
.header .showcase__left__matn a:nth-child(2) {
  color: white;
  background: #001a4d;
}
.header .showcase__left__matn a:nth-child(2):hover {
  background: grey;
  color: white;
}
.header .showcase__right {
  width: 50%;
  z-index: 70;
}
.header .showcase__right img {
  width: 100%;
  height: 100%;
  z-index: 9;
}
@media (max-width: 900px) {
  .header .showcase {
    flex-direction: column;
    padding: 0;
  }
  .header .showcase__left {
    width: 100%;
    order: 1;
    align-items: center;
    vertical-align: middle;
  }
  .header .showcase__left__fast {
    font-size: 14px;
    padding: 5px 10px;
  }
  .header .showcase__left h2 {
    font-size: 38px;
  }
  .header .showcase__left__text {
    width: 90%;
  }
  .header .showcase__right {
    width: 80%;
    order: 2;
    height: 300px;
  }
}
@media (max-width: 400px) {
  .header .showcase__left .one {
    font-size: 30px;
  }
  .header .showcase__left h2 {
    font-size: 25px;
  }
  .header .showcase__left__text {
    width: 90%;
  }
  .header .showcase__left__matn {
    flex-direction: column;
    row-gap: 10px;
  }
  .header .showcase__left__matn img {
    display: none;
  }
  .header .showcase__right {
    width: 100%;
    order: 1;
    height: 200px;
  }
}

.container .section {
  z-index: 99;
}
.container .section p {
  color: #003459;
  margin-top: 25px;
}
.container .section .title {
  display: flex;
  justify-content: space-between;
}
.container .section .title h2 {
  color: #003459;
}
.container .section .title a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: #003459;
  z-index: 10;
  border: 1px solid #003459;
  padding: 8px 30px;
}
.container .section .title a:hover {
  background: #003459;
  color: red;
  text-decoration: none;
}
.container .section .area {
  padding-top: 30px;
}
.container .section .area .infor-puppys {
  display: grid;
  gap: 20px;
  grid-template-columns: repeat(4, 24%);
}
.container .section .area .infor-puppys .infor-puppy {
  border-radius: 10px;
  width: 100%;
  background-color: white;
  box-shadow: 0px 4px 28px -20px rgba(0, 0, 0, 0.8);
}
.container .section .area .infor-puppys .infor-puppy img {
  border-radius: 10px;
}
.container .section .area .infor-puppys .infor-puppy .malumot1 {
  padding: 15px;
}
.container .section .area .infor-puppys .infor-puppy .malumot1 h3 {
  font-size: 16px;
  padding-bottom: 10px;
  color: #00171F;
}
.container .section .area .infor-puppys .infor-puppy .malumot1 p {
  font-size: 15px;
  padding-bottom: 20px;
  color: #65665C;
}
.container .section .area .infor-puppys .infor-puppy > img {
  width: 100%;
}

@media (max-width: 1024px) {
  .container .section .area .infor-puppys {
    display: grid;
    grid-template-columns: repeat(2, 48%);
    justify-content: space-between;
    row-gap: 50px;
  }
}
@media (max-width: 700px) {
  .container .section .area h2 {
    font-size: 37px;
  }
  .container .section .area .infor-puppys {
    display: grid;
    grid-template-columns: repeat(2, 48%);
    row-gap: 50px;
  }
}
@media (max-width: 400px) {
  .container .section .area h2 {
    font-size: 37px;
  }
  .container .section .area .infor-puppys {
    display: grid;
    grid-template-columns: repeat(2, 48%);
    row-gap: 50px;
  }
}
.container .section1 .showcase1 {
  margin-top: 100px;
  background: #003459;
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 100%;
  padding: 50px 0px;
}
.container .section1 .showcase1__left {
  width: 50%;
  position: relative;
}
.container .section1 .showcase1__left .one {
  font-size: 55px;
  word-spacing: 15px;
  color: white;
}
.container .section1 .showcase1__left p {
  color: white;
}
.container .section1 .showcase1__left h2 {
  font-size: 48px;
  width: 100%;
  padding: 10px 0px;
  margin: 0;
}
.container .section1 .showcase1__left__text {
  font-size: 16px;
  padding-bottom: 20px;
  color: white;
}
.container .section1 .showcase1__left__matn {
  display: flex;
  column-gap: 20px;
  align-items: center;
}
.container .section1 .showcase1__left__matn img {
  height: 20px;
}
.container .section1 .showcase1__left__matn a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: inherit;
  background-color: transparent;
  z-index: 10;
  border: 1px solid blue;
  padding: 10px 30px;
}
.container .section1 .showcase1__left__matn a:hover {
  background: grey;
  color: white;
  text-decoration: none;
}
.container .section1 .showcase1__left__matn a:nth-child(1) {
  color: white;
  background: grey;
}
.container .section1 .showcase1__left__matn a:nth-child(1):hover {
  background: #001a4d;
  color: white;
}
.container .section1 .showcase1__left__matn a:nth-child(2) {
  color: white;
  background: #001a4d;
}
.container .section1 .showcase1__left__matn a:nth-child(2):hover {
  background: grey;
  color: white;
}
.container .section1 .showcase1__right {
  width: 50%;
  z-index: 70;
}
.container .section1 .showcase1__right img {
  width: 100%;
  height: 100%;
  z-index: 9;
}

@media (max-width: 900px) {
  .showcase1 {
    flex-direction: column;
    padding: 0;
  }
  .showcase1__left {
    width: 100%;
    order: 1;
    align-items: center;
    vertical-align: middle;
  }
  .showcase1__left h2 {
    font-size: 38px;
    width: 100%;
  }
  .showcase1__left__text {
    width: 90%;
  }
  .showcase1__right {
    width: 100%;
    order: 2;
    height: 300px;
  }
}
@media (max-width: 400px) {
  .showcase1__left .one p {
    font-size: 10px;
  }
  .showcase1__left p {
    font-size: 30px;
  }
  .showcase1__left__text {
    width: 100%;
    padding-top: 20px;
  }
  .showcase1__left__matn {
    flex-direction: column;
    row-gap: 10px;
  }
  .showcase1__left__matn img {
    display: none;
  }
  .showcase1__right {
    width: 100%;
    order: 2;
    height: 200px;
  }
}
.container .section2 {
  z-index: 99;
}
.container .section2 p {
  color: #003459;
  margin-top: 25px;
}
.container .section2 .title {
  display: flex;
  justify-content: space-between;
}
.container .section2 .title h2 {
  color: #003459;
}
.container .section2 .title a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: #003459;
  z-index: 10;
  border: 1px solid #003459;
  padding: 8px 30px;
}
.container .section2 .title a:hover {
  background: #003459;
  color: red;
  text-decoration: none;
}
.container .section2 .area {
  padding-top: 30px;
}
.container .section2 .area .infor-puppys {
  display: grid;
  gap: 20px;
  grid-template-columns: repeat(4, 24%);
}
.container .section2 .area .infor-puppys .infor-puppy {
  border-radius: 10px;
  width: 100%;
  background-color: white;
  box-shadow: 0px 4px 28px -20px rgba(0, 0, 0, 0.8);
}
.container .section2 .area .infor-puppys .infor-puppy img {
  border-radius: 10px;
}
.container .section2 .area .infor-puppys .infor-puppy .malumot1 {
  padding: 15px;
}
.container .section2 .area .infor-puppys .infor-puppy .malumot1 h3 {
  font-size: 16px;
  padding-bottom: 10px;
  color: #00171F;
}
.container .section2 .area .infor-puppys .infor-puppy .malumot1 p {
  font-size: 15px;
  padding-bottom: 20px;
  color: #65665C;
}
.container .section2 .area .infor-puppys .infor-puppy .malumot1 .btn {
  background: #FCEED5;
  border-radius: 8px;
  color: #002A48;
  font-weight: 700;
  font-size: 14px;
  line-height: 20px;
  padding: 8px 12px;
}
.container .section2 .area .infor-puppys .infor-puppy > img {
  width: 100%;
}

@media (max-width: 1024px) {
  .container .section2 .area .infor-puppys {
    display: grid;
    grid-template-columns: repeat(2, 48%);
    justify-content: space-between;
    row-gap: 50px;
  }
}
@media (max-width: 835px) {
  .container .section2 .area h2 {
    font-size: 37px;
  }
  .container .section2 .area .infor-puppys {
    display: grid;
    grid-template-columns: repeat(1, 100%);
    row-gap: 50px;
  }
}
@media (max-width: 386px) {
  .container .section2 {
    display: none;
  }
  .container .section2 .area h2 {
    font-size: 37px;
  }
  .container .section2 .area .infor-puppys {
    display: grid;
    grid-template-columns: repeat(1, 100%);
    row-gap: 50px;
  }
}
.container .section3 .ikki {
  margin-top: 50px;
  display: flex;
  justify-content: space-between;
  z-index: 99;
}
.container .section3 .part {
  margin-top: 40px;
  display: flex;
  flex-wrap: wrap;
  flex-direction: row;
  gap: 10px;
  justify-content: space-between;
}
.container .section3 .birga {
  display: flex;
  gap: 15px;
}
.container .section3 .birga h3 {
  padding-top: 20px;
}
.container .section3 p {
  color: #003459;
  margin-top: 25px;
}
.container .section3 .title {
  display: flex;
  justify-content: space-between;
}
.container .section3 .title h2 {
  color: #003459;
}
.container .section3 .title a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: #003459;
  z-index: 10;
  border: 1px solid #003459;
  padding: 8px 30px;
}
.container .section3 .title a:hover {
  background: #003459;
  color: red;
  text-decoration: none;
}

@media (max-width: 835px) {
  .container .section3 {
    display: none;
  }
  .container .section4 {
    display: none;
  }
}
@media (max-width: 386px) {
  .container .section3 {
    display: none;
  }
}
.container .section4 .showcase2 {
  margin-top: 100px;
  background: #FFB775;
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 100%;
  padding: 50px 0px;
  position: relative;
}
.container .section4 .showcase2__left {
  width: 50%;
  padding-left: 10%;
  position: relative;
}
.container .section4 .showcase2__left .one {
  word-spacing: 15px;
  color: #003459;
  font-weight: 800;
  font-size: 52px;
  line-height: 68px;
}
.container .section4 .showcase2__left p {
  color: #003459;
  font-weight: 700;
  font-size: 36px;
  line-height: 54px;
}
.container .section4 .showcase2__left h2 {
  font-size: 48px;
  width: 100%;
  padding: 10px 0px;
  margin: 0;
}
.container .section4 .showcase2__left__text {
  font-size: 16px;
  padding-bottom: 20px;
  color: #003459;
}
.container .section4 .showcase2__left__matn {
  display: flex;
  column-gap: 20px;
  align-items: center;
}
.container .section4 .showcase2__left__matn img {
  height: 20px;
}
.container .section4 .showcase2__left__matn a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: inherit;
  background-color: transparent;
  z-index: 10;
  border: 1px solid blue;
  padding: 10px 30px;
}
.container .section4 .showcase2__left__matn a:hover {
  background: grey;
  color: white;
  text-decoration: none;
}
.container .section4 .showcase2__left__matn a:nth-child(1) {
  color: white;
  background: #001a4d;
}
.container .section4 .showcase2__left__matn a:nth-child(1):hover {
  background: grey;
  color: red;
}
.container .section4 .showcase2__left__matn a:nth-child(2) {
  color: #001a4d;
  background: #FCEED5;
}
.container .section4 .showcase2__left__matn a:nth-child(2):hover {
  color: red;
  background: grey;
}
.container .section4 .showcase2__right {
  width: 50%;
  z-index: 70;
}
.container .section4 .showcase2__right img {
  width: 100%;
  height: 100%;
  z-index: 9;
}
.container .section4 .on {
  position: absolute;
  right: 0;
  bottom: 50px;
  width: 500px;
  height: 500px;
  z-index: 1;
}
.container .section4 .off {
  position: absolute;
  top: 0;
  left: 0;
  width: 500px;
  height: 500px;
  z-index: 1;
}

@media (max-width: 900px) {
  .showcase2 {
    flex-direction: column;
    padding: 0;
  }
  .showcase2__left {
    width: 100%;
    order: 1;
    align-items: center;
    vertical-align: middle;
  }
  .showcase2__left h2 {
    font-size: 38px;
    width: 100%;
  }
  .showcase2__left__text {
    width: 90%;
  }
  .showcase2__right {
    width: 100%;
    order: 2;
    height: 300px;
  }
}
@media (max-width: 400px) {
  .showcase2__left .one p {
    font-size: 10px;
  }
  .showcase2__left p {
    font-size: 30px;
  }
  .showcase2__left__text {
    width: 100%;
    padding-top: 20px;
  }
  .showcase2__left__matn {
    flex-direction: column;
    row-gap: 10px;
  }
  .showcase2__left__matn img {
    display: none;
  }
  .showcase2__right {
    width: 100%;
    order: 2;
    height: 200px;
  }
}
.container .section5 {
  z-index: 99;
}
.container .section5 p {
  color: #003459;
  margin-top: 25px;
}
.container .section5 .title {
  display: flex;
  justify-content: space-between;
}
.container .section5 .title h2 {
  color: #003459;
}
.container .section5 .title a {
  font-size: 17px;
  display: inline-block;
  padding: 6px 15px;
  border-radius: 20px;
  color: #003459;
  z-index: 10;
  border: 1px solid #003459;
  padding: 8px 30px;
}
.container .section5 .title a:hover {
  background: #003459;
  color: red;
  text-decoration: none;
}
.container .section5 .infor-knows {
  display: grid;
  grid-template-columns: repeat(3, 32%);
  justify-content: space-between;
  width: 100%;
  margin-top: 50px;
}
.container .section5 .infor-knows .infor-know {
  border-radius: 10px;
  width: 100%;
  background-color: white;
  box-shadow: 0px 4px 28px -20px rgba(0, 0, 0, 0.8);
}
.container .section5 .infor-knows .infor-know img {
  border-radius: 10px;
  width: 100%;
}
.container .section5 .infor-knows .infor-know .malumot1 {
  padding: 15px;
}
.container .section5 .infor-knows .infor-know .malumot1 h3 {
  font-size: 16px;
  padding-bottom: 10px;
  color: #00171F;
}
.container .section5 .infor-knows .infor-know .malumot1 p {
  font-size: 15px;
  padding-bottom: 20px;
  color: #242B33;
  font-weight: 400;
  font-family: "SVN-Gilroy";
  text-align: justify;
}
.container .section5 .infor-knows .infor-know .malumot1 .btn3 {
  background: #00A7E7;
  border-radius: 28px;
  color: #FDFDFD;
  font-weight: 700;
  font-size: 14px;
  line-height: 20px;
  padding: 4px 12px;
  border: none;
  margin-bottom: 20px;
}
.container .section5 .infor-knows .infor-knows > img {
  width: 100%;
}

@media (max-width: 835px) {
  .container .section5 .infor-knows {
    grid-template-columns: repeat(1, 70%);
    justify-content: center;
    grid-gap: 20px;
  }
  .container .section5 .infor-knows .yoq {
    display: none;
  }
}
@media (max-width: 386px) {
  .container .section5 .infor-knows {
    grid-template-columns: repeat(1, 70%);
    justify-content: center;
    grid-gap: 20px;
  }
  .container .section5 .infor-knows .yoq {
    display: block;
  }
}
.container .footer {
  margin-top: 100px;
  background: #FCEED5;
  border-radius: 40px 40px 0px 0px;
  padding: 40px;
}
.container .footer__top {
  display: flex;
  background: #003459;
  border-radius: 16px;
}
.container .footer__top p {
  padding: 20px;
  color: #fff;
  font-weight: 700;
  font-size: 24px;
  line-height: 36px;
}
.container .footer__top .btns {
  width: 70%;
  display: flex;
  gap: 10px;
  background-color: white;
  border-radius: 14px;
  margin: 20px;
}
.container .footer__top .btns .btr1 {
  width: 70%;
  text-align: start;
  padding-left: 10px;
  margin: 10px;
  border-radius: 8px;
  font-weight: 500;
  font-size: 14px;
  line-height: 20px;
  color: grey;
  border: 1px solid #99A2A5;
  padding: 4px 12px;
}
.container .footer__top .btns .btr2 {
  width: 30%;
  background: #003459;
  color: #fff;
  margin: 10px;
  border-radius: 8px;
  font-weight: 500;
  font-size: 16px;
  line-height: 24px;
  padding: 8px 12px;
}
.container .footer__middle {
  display: flex;
  justify-content: space-between;
  align-items: center;
  border-bottom: 2px solid gray;
}
.container .footer__middle ul {
  display: flex;
  gap: 15px;
  padding: 30px;
}
.container .footer__middle .icons {
  display: flex;
  gap: 40px;
}
.container .footer__middle .icons i {
  font-size: 22px;
  color: #00171F;
}
.container .footer__bottom {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.container .footer__bottom p {
  color: #667479;
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 20px;
  padding: 40px;
}
.container .footer__bottom .foot_media {
  width: 110px;
  height: 50px;
}

@media (max-width: 835px) {
  .container .footer__top {
    flex-direction: column;
  }
  .container .footer__middle {
    flex-direction: column;
  }
  .container .footer__middle .icons {
    padding-bottom: 20px;
  }
  .container .footer__bottom {
    flex-direction: column;
  }
  .container .footer__bottom p {
    order: 2;
  }
  .container .footer__bottom .foot_media {
    order: 1;
    margin-top: 20px;
  }
}
@media (max-width: 386px) {
  .container .footer__top .btns {
    flex-direction: column;
  }
  .container .footer__top .btns .btr1 {
    width: 90%;
  }
  .container .footer__top .btns .btr2 {
    width: 90%;
  }
}

/*# sourceMappingURL=main.cs.map */
