import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import { Home } from './Home';
import { Layout } from './Layout';
import { AddCandidate } from './Pages/AddCandidate';
import { Pending } from './Pages/Pending';
import { Confirmed } from './Pages/Confirmed';
import { Refused } from './Pages/Refused';

import { CandidatesContextComponent } from './CandidateContext';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
      return (
        <CandidatesContextComponent>
         <Layout>
                <Route exact path='/' component={Home} />
                <Route exact path='/addcandidate' component={AddCandidate} />
                <Route exact path='/pending' component={Pending} />
                <Route exact path='/confirmed' component={Confirmed} />
                <Route exact path='/refused' component={Refused} />
                <Route exact path='/details/:id' component={Details}/>
           </Layout>
       </CandidatesContextComponent>
    );
  }
}
