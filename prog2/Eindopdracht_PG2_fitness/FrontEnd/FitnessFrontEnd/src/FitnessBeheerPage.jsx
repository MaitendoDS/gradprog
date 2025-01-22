import { useParams } from "react-router-dom";
import { useEffect, useState } from "react";

function FitnessBeheerPage() {
  const { id } = useParams();


  const [message, setMessage] = useState('');
  const [messageStyle, setMessageStyle] = useState(0);
  const [date, setDate] = useState('');
  const [timeslot1, setTimeslot1] = useState('');
  const [timeslot2, setTimeslot2] = useState('');
  const [timeslot3, setTimeslot3] = useState('');
  const [timeslot4, setTimeslot4] = useState('');

  const [equipment1, setEquipment1] = useState('');
  const [equipment2, setEquipment2] = useState('');
  const [equipment3, setEquipment3] = useState('');
  const [equipment4, setEquipment4] = useState('');
  const [data, setData] = useState([]);

  const timeslots = [
    '08:00 - 09:00',
    '09:00 - 10:00',
    '10:00 - 11:00',
    '11:00 - 12:00',
    '12:00 - 13:00',
    '13:00 - 14:00',
    '14:00 - 15:00',
    '15:00 - 16:00',
    '16:00 - 17:00',
    '17:00 - 18:00',
    '18:00 - 19:00',
    '19:00 - 20:00',
    '20:00 - 21:00',
    '21:00 - 22:00'
  ];

  useEffect(() => {
    fetch("http://localhost:5253/api/Equipment")
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error(error));
  }, []);

  

  const handleSubmit = (event) => {
    event.preventDefault();

    const reservationData = { 
      "EquipmentID1":equipment1 || '0' ,
      "TimeSlotID1":timeslot1 || '0',

      "EquipmentID2":equipment2 || '0',
      "TimeSlotID2":timeslot2 || '0',

      "EquipmentID3":equipment3 || '0',
      "TimeSlotID3":timeslot3 || '0',

      "EquipmentID4":equipment4 || '0',
      "TimeSlotID4":timeslot4 || '0',
      date,
      "MemberID":id 
      
    };
    console.log("klik")

      fetch("http://localhost:5253/api/Reservation", {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(reservationData),
      })
      .then((response) => response.json())
      .then((data) => {
        if (data.message) {
          setMessage(data.message);
          setMessageStyle(1);
        } else {
          setMessage('An error occurred while making the reservation.');
          setMessageStyle(1);
        }
      })
      .catch(() => {
        setMessage('Reservation successfully made!');
          setMessageStyle(0);
      });
       
    

  };



  const containerStyle = {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',
    minHeight: '100vh',
    backgroundColor: '#f0f4f8',
    fontFamily: 'Roboto, sans-serif',
  };

  const formStyle = {
    backgroundColor: 'white',
    padding: '40px',
    borderRadius: '10px',
    boxShadow: '0 6px 12px rgba(0, 0, 0, 0.1)',
    width: '100%',
    maxWidth: '600px',
    display: 'flex',
    flexDirection: 'column',
  };

  const h1Style = {
    color: '#2c3e50',
    fontSize: '2.5rem',
    marginBottom: '40px',
    textAlign: 'center',
  };

  const labelStyle = {
    fontSize: '1.1rem',
    color: '#7f8c8d',
    marginBottom: '10px',

  };

  const inputStyle = {
    width: '100%',
    padding: '12px',
    fontSize: '1rem',
    border: '1px solid #bdc3c7',
    borderRadius: '8px',
    boxSizing: 'border-box',
    color: '#34495e',
  };

  const selectStyle = {
    width: '100%',
    padding: '12px',
    fontSize: '1rem',
    border: '1px solid #bdc3c7',
    borderRadius: '8px',
    boxSizing: 'border-box',
    color: '#34495e',
    margin :'2px'
  };

  const buttonStyle = {
    backgroundColor: '#3498db',
    color: 'white',
    padding: '12px',
    border: 'none',
    borderRadius: '8px',
    fontSize: '1.2rem',
    cursor: 'pointer',
    transition: 'background-color 0.3s ease',
    width: '100%',
  };

  const buttonHoverStyle = {
    backgroundColor: '#2980b9',
  };

  return (
    <div style={containerStyle}>
      <h1 style={h1Style}>Fitness Beheer Formulier</h1>
      <form onSubmit={handleSubmit} style={formStyle}>
        <div style={{ marginBottom: '25px' }}>
          <label htmlFor="date" style={labelStyle}>Datum</label>
          <input
            type="date"
            id="date"
            value={date}
            onChange={(e) => setDate(e.target.value)}
            required
            style={inputStyle}
          />
        </div>

        <div style={{ marginBottom: '25px' }}>
          <label htmlFor="timeslot" style={labelStyle}>Tijdslot</label>
          <select
            id="timeslot"
            value={timeslot1}
            onChange={(e) => setTimeslot1(e.target.value)}
            required
            style={selectStyle}
          >
            <option value="">Selecteer een tijdslot</option>
            {timeslots.map((slot, index) => (
              <option key={index} value={index+1}>
                {slot}
              </option>
            ))}
          </select>
          <select
            id="timeslot"
            value={timeslot2}
            onChange={(e) => setTimeslot2(e.target.value)}
            style={selectStyle}
          >
            <option value="">Selecteer eventueel nog een tijdslot</option>
            {timeslots.map((slot, index) => (
              <option key={index} value={index+1}>
                {slot}
              </option>
            ))}
          </select>
          <select
            id="timeslot"
            value={timeslot3}
            onChange={(e) => setTimeslot3(e.target.value)}
            style={selectStyle}
          >
            <option value="">Selecteer eventueel nog een tijdslot</option>
            {timeslots.map((slot, index) => (
              <option key={index} value={index+1}>
                {slot}
              </option>
            ))}
          </select>
          <select
            id="timeslot"
            value={timeslot4}
            onChange={(e) => setTimeslot4(e.target.value)}
        
            style={selectStyle}
          >
            <option value="">Selecteer eventueel nog een tijdslot</option>
            {timeslots.map((slot, index) => (
              <option key={index} value={index+1}>
                {slot}
              </option>
            ))}
          </select>
        </div>
        

        <div style={{ marginBottom: '25px' }}>
          <label htmlFor="equipment" style={labelStyle}>Apparatuur</label>
          <select
            id="equipment"
            value={equipment1}
            onChange={(e) => setEquipment1(e.target.value)}
            required
            style={selectStyle}
          >
            <option value="">Selecteer apparaat</option>
            {data.map((item, index) => (
              <option key={index} value={item.equipmentID}>
                {item.deviceType}
              </option>
            ))}
          </select>
          <select
            id="equipment"
            value={equipment2}
            onChange={(e) => setEquipment2(e.target.value)}
            style={selectStyle}
          >
            <option value="">Selecteer eventueel nog een apparaat</option>
            {data.map((item, index) => (
              <option key={index} value={item.equipmentID}>
                {item.deviceType}
              </option>
            ))}
          </select>
          <select
            id="equipment"
            value={equipment3}
            onChange={(e) => setEquipment3(e.target.value)}
            style={selectStyle}
          >
            <option value="">Selecteer eventueel nog een apparaat</option>
            {data.map((item, index) => (
              <option key={index} value={item.equipmentID}>
                {item.deviceType}
              </option>
            ))}
          </select>
          <select
            id="equipment"
            value={equipment4}
            onChange={(e) => setEquipment4(e.target.value)}
            style={selectStyle}
          >
            <option value="">Selecteer eventueel nog een apparaat</option>
            {data.map((item, index) => (
              <option key={index} value={item.equipmentID}>
                {item.deviceType}
              </option>
            ))}
          </select>

        </div>
       

        <div>
          <button
            type="submit"
            style={buttonStyle}
            onMouseEnter={e => e.target.style.backgroundColor = buttonHoverStyle.backgroundColor}
            onMouseLeave={e => e.target.style.backgroundColor = buttonStyle.backgroundColor}
          >
            Verzenden
          </button>
          <p style={{ color: messageStyle === 0 ? 'green' : 'red' }}>
           {message}
          </p>

        </div>
      </form>
    </div>
  );
}

export default FitnessBeheerPage;
