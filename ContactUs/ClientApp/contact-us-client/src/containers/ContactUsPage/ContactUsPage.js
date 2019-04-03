import React, { useState } from 'react';
import { Fade } from 'react-bootstrap';
import './ContactUsPage.css';
import ContactForm from '../../components/ContactForm/ContactForm';
import postMessage from '../../api/ContactUsAPI';

const ContactUsPage = props => {

  const [success, setSuccess] = useState("");

  const handleSubmit = async (data) => {
    const result = await postMessage(data);
    if(result.success && result.success === "true"){
      setSuccess("true");
    setTimeout(() => {
      setSuccess("")
    }, 3000);
    } else {
      setSuccess("false");
    setTimeout(() => {
      setSuccess("")
    }, 3000);
    }
    
    console.log(result);
  }

  return (
    <div className="contact-us">

      <div className="form-wrapper">
        <h1>Contact Me!</h1>
        <ContactForm submitHandler={handleSubmit} />
        <Fade in={success === "true"}>
        <div className="alert alert-dismissible alert-success">
          Message sent successfully.
        </div>
        </Fade>
        <Fade in={success === "false"}>
        <div className="alert alert-dismissible alert-danger">
          Message failed to send.
        </div>
        </Fade>
        
      </div>

    </div>
  );
}

export default ContactUsPage;