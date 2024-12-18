import { useParams } from "react-router-dom";
import { useEffect, useState } from "react";

function FitnessBeheerPage() {
  const { id } = useParams();

  const [date, setDate] = useState('');
  const [timeslot, setTimeslot] = useState('');
  const [equipment, setEquipment] = useState('');
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
    fetch("http://localhost:5253/api/Equipment/GetAllEquipment")
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error(error));
  }, []);

  const handleSubmit = (event) => {
    event.preventDefault();

    const reservationData = { "equipmentID":equipment, "timeSlotID":timeslot, date, "memberID":id };

      fetch("http://localhost:5253/api/Reservation/AddReservation", {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(reservationData),
      })
        .then((response) => response.json())
       
    
    console.log({ date, timeslot, equipment });
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
            value={timeslot}
            onChange={(e) => setTimeslot(e.target.value)}
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
        </div>

        <div style={{ marginBottom: '25px' }}>
          <label htmlFor="equipment" style={labelStyle}>Apparatuur</label>
          <select
            id="equipment"
            value={equipment}
            onChange={(e) => setEquipment(e.target.value)}
            required
            style={selectStyle}
          >
            <option value="">Selecteer apparatuur</option>
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
        </div>
      </form>
    </div>
  );
}

export default FitnessBeheerPage;
