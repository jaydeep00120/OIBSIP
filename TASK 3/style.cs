@import url('https://fonts.googleapis.com/css2?family=Roboto+Mono:wght@500&display=swap');


* {
  margin: 15;
  padding: 10;
  box-sizing: border-box;
  font-family: 'Roboto Mono';
  font-size: 21px;
}

body {
  height: 100vh;
  background-color:rgb(215, 246, 250);
  display: flex;
  align-items: center;
  justify-content: center;
}

.container {
  width: 750px;
  background-color: rgb(164, 222, 243);
  padding: 150px 80px;
  box-shadow: 0 20px 25px rgba(0, 0, 0, 0.25);
  border-radius: 15px;
  display: flex;
  justify-content: space-between;
}

.cf {
  width: 205%;
}

input {
  width: 100%;
  height: 60px;
  border-radius: 15px;
  border: 2px solid #e81212;
  outline: none;
  margin-top: 8px;
  padding: 0 10px;
}

input:focus {
  border-color: #5e8b7e;
}