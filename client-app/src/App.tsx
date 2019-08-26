import './App.css';
import { Header } from 'semantic-ui-react';
import React, { Component } from 'react';

export default class App extends Component {
  render() {
    return (
      <div>
        <Header as="h3" dividing>
          Values
        </Header>
      </div>
    );
  }
}
