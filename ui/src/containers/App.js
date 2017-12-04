import React from 'react';
import CounterPage from './CounterPage';
import Home from './HomePage';

import { View,Text } from 'react-native'
import { NativeRouter, Link, Route } from 'react-router-native';

const navItem = {
  flex:1,
  alignItems: 'center',
  padding: 10,
}

export default class App extends React.Component {
  render() {
    return (
      <NativeRouter>
        <View style={{
          marginTop: 25,
          padding:10,
        }}>
          <View style={{
            flexDirection: 'row',
            justifyContent: 'space-around'
          }}>
            <Link 
              to="/counter"
              underlayColor='#f0f4f70'>
              <Text>Counter</Text>
            </Link>
            <Link 
              to="/"
              underlayColor='#f0f4f70'>
              <Text>Home</Text>
            </Link>
            <Route exact path="/" component={Home} />
            <Route path="/counter" component={CounterPage} />
          </View>
        </View>
      </NativeRouter>
    )
  }
}
