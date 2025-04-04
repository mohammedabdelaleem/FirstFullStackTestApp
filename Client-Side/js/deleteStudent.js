const API_URL_All = "http://localhost:5087/api/students/all"
const API_URL_Delete = "http://localhost:5087/api/students/"


// Function to fetch the students list and display it
    function getAllStudents() {
        fetch(API_URL_All)  // Adjust API endpoint
            .then(response => response.json())
            .then(data => {
                const tableBody = document.getElementById('studentsTableBody');
                let counter = 1;
                tableBody.innerHTML = '';  // Clear existing rows
                data.forEach(student => {

                    const row = document.createElement('tr');
                    row.innerHTML = `
                        <td>${counter++}</td>
                        <td>${student.name}</td>
                        <td>${student.age}</td>
                        <td>${student.grade}</td>
                        <td>
                          <button class="btn btn-danger" onclick="deleteStudent('${student.id}')">Delete</button>
                          <button >Edit</button>
                        </td>

                    `;
                    tableBody.appendChild(row);
                });
            })
            .catch(error => console.error('Error fetching students:', error));
    }


    // Function to delete a student by ID
    function deleteStudent(studentId,  redirect = false) {
      if (confirm('Are you sure you want to delete this student?')) {
          fetch(`${API_URL_Delete}${studentId}`, {
              method: 'DELETE'
          })
          .then(async response => {
              if (response.ok) {
                  // alert('Student removed successfully!');
                  if (redirect) {
                    window.location.href = "getAllStudents.html"; // redirect 
                }
                else {
                  await getAllStudents(); // Refresh after user clicks OK
                }
                
              } else {
                  alert('Failed to delete student');
              }
          })
          .catch(error => console.error('Error deleting student:', error));
      }
  }
  

    // Initialize by loading the student list
    window.onload = async function() {
    await  getAllStudents();
  };