import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

const App = () => {
  const [data, setData] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5253/api/Member/GetAll")
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error(error));
  }, []);

  


  const handleNavigate = (memberID) => {
    navigate(`/FitnessBeheerPage/${memberID}`);
  };



  return (
    <div>
      <h1> Data van de API</h1>
      <ul>
        {data.map((member, index) => {
          return (
            <li key={index}>

              <button onClick={() => handleNavigate(member.memberID)} >Maak reservatie</button>
              <strong>MemberID:</strong> {member.memberID} <br />
              <strong>FirstName:</strong> {member.firstName} <br />
              <strong>LastName:</strong> {member.lastName} <br />
              <strong>Email:</strong> {member.email} <br />
              <strong>Adress:</strong> {member.adress} <br />
              <strong>Birthday:</strong> {member.birthday}<br />
              <strong>Interests:</strong> {member.interests.join(", ")} <br />
              <strong>MemberType:</strong> {member.memberType}
            </li>


          );
        })}
      </ul>
    </div>
  );
};

export default App;
