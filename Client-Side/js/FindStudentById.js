const API_URL = "http://localhost:5087/api/students/";

function displayStudent(student) {
  studentDetails.innerHTML = `<h2 class="studentCardTitle">Student Details</h2>
  <p class="std-info">Name:${student.name}</p>
  <p class="std-info">Age: ${student.age}</p>
  <p class="std-info">Grade: ${student.grade.toFixed(2)}</p>
  <button class="btn btn-danger" onclick="deleteStudent('${student.id}', true)">Delete</button>
`;
}

async function getStudentById(studentId) {
  try {
    const response = await fetch(`${API_URL}${studentId}`);

    if (!response.ok) {
      throw new Error("Student not found");
    }

    const student = await response.json();
    displayStudent(student);
  } catch (error) {
    console.error("Error fetching student:", error);
    studentDetails.innerHTML = `<p style="color:red;">${error.message}</p>`;
  }
}

getStudentBtn.addEventListener("click", (eo) => {
  const studentId = studentIdInput.value.trim();
  if (studentId) {
    getStudentById(studentId);
  } else {
    alert("Enter A Valid Id !!!");
  }
});
