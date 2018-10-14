import React from 'react';
import ReactDOM from 'react-dom';
import Theme from './components/Theme';
import jquery from 'jquery';
import Popper from 'popper.js';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import 'bootstrap/dist/css/bootstrap.min.css';
import './app.css';
ReactDOM.render(
   <Theme />,
   document.getElementById('root')
);
module.hot.accept();