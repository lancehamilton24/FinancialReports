import React from 'react';
import './Home.css';

class Home extends React.Component {

  state = {
  }

  componentDidMount() {

  }

  render() {

    return (
      <div className="container">
        <h1>Fincancial Statement Analysis</h1>
        <input class="form-control form-control-lg" type="text" placeholder="Enter Company Ticker"></input>
        <button type="button" class="btn btn-dark">Get Data</button>
      </div>
    );
  }
}


export default Home;
