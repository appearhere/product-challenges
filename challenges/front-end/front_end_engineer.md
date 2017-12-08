# Appear Here Front End Engineer Code Discussion

Hello,

Thanks for agreeing to walk through some code with us over a video call.

It may help to have a brief look over the code beforehand, but don't worry about that too much as we will be looking at it during the call.

This is to help us gauge how well we would work together.

Please have the code ready in a text editor.

Speak soon,
Appear Here

## Form.css

```css
.Form {
  width: 50%;
  display: flex;
  flex-direction: column;
}

.Form * {
  margin-bottom: 30px;
}

.Form input {
  width: 10%;
  transition: width 2s;
}

.Form input:focus {
  width: 100%;
}

.no-padding {
  margin-bottom: 0;
}
```

## Form.jsx

```jsx
import React, { Component } from 'react';

import './Form.css';

class Form extends Component {
  state = {
    form: {
      firstName: '',
      lastName: '',
      email: '',
      password: '',
    },
  };


  handleFirstNameChange = (e) => {
    this.setState({
      form: {
        firstName: e.target.value,
      },
    });
  };

  handleLastNameChange = (e) => {
    this.setState({
      form: {
        lastName: e.target.value,
      },
    });
  };

  handleEmailChange = (e) => {
    this.setState({
      form: {
        email: e.target.value,
      },
    });
  };

  handlePasswordChange = (e) => {
    this.setState({
      form: {
        password: e.target.value,
      },
    });
  };

  validateForm = () => {
    const formInputs = ['firstName', 'lastName', 'emailAddress', 'password'];

    for ( let i = 0; i < formInputs.length; i++ ) {
      const inputName = formInputs[i];

      if (!this.state.form[inputName].length) {
        return false;
      }
    }

    return true;
  };

  handleSubmit = () => {
    if (this.validateForm()) {
      console.log('Success!');
    } else {
      console.log('Failure!');
    }
  };

  render() {
    return (
      <div style={ { display: 'flex', justifyContent: 'center', alignItems: 'center' } }>
        <form
          className="Form"
          onSubmit={ (e) => {
            e.preventDefault();
            this.handleSubmit();
          } }
        >
          <input name="firstName" onChange={ this.handleFirstNameChange }/>
          <input name="lastName" onChange={ this.handleLastNameChange }/>
          <input name="email" onChange={ this.handleEmailChange }/>
          <input name="password" onChange={ this.handlePasswordChange }/>
          <button className="no-padding">Submit</button>
        </form>
      </div>
    );
  }
}

export default Form;
```
