var arrFirstname = ['Arto', 'Pekka', 'Väinö', 'Kalevi'];
var arrLastname = ['Ala-talo', 'Bengtson', 'Kallio', 'Taipale'];
var arrPhone = ['0400 952 874','055 6547 987','044 6564 789','09 6587 9655'];
var arrStreetaddress = ['Valtakatu 34','Keskuspuisto 1','Peikkokuja 67', 'Tammikuja 5'];
var arrCity = ['Oulu', 'Tampere','Lahti','Imatra'];
var copyLN = [];
var pos = 0;

// shows sorted list without add-funtion
function listit(){
    for (var j = 0; j < arrLastname.length; j++)      // copy last names and sort array for ascending listing
    {
        copyLN.push(arrLastname[j])
    }
    copyLN.sort();

    document.getElementById("showlist").lastElementChild.innerHTML = "";

    for (var i = 0; i < arrLastname.length; i++)      // shows the inputs
    {
        pos = arrLastname.indexOf(copyLN[i]);
        document.getElementById("showlist").lastElementChild.innerHTML += "<tr><td>" + arrLastname[pos] + "</td> <td>" + arrFirstname[pos] + "</td> <td>" +
            arrPhone[pos] + "</td>" + "<td>" + arrStreetaddress[pos] + "</td>" + "<td>" + arrCity[pos] + "</td></tr>";

    }
}
// adds a nes contact and updates the contact list and sows it in sorted order
function addToList()
{
    copyLN.length = 0;
    var fn = document.getElementById("Firstname").value;
    arrFirstname.push(fn);
    // arrFirstname.add(fn);
    var ln = document.getElementById("Lastname").value;
    arrLastname.push(ln);
    var p = document.getElementById("Phone").value;
    arrPhone.push(p);
    var stra = document.getElementById("Streetaddress").value;
    arrStreetaddress.push(stra);
    var c = document.getElementById("City").value;
    arrCity.push(c);

    for (var j = 0; j < arrLastname.length; j++)      // copy last names and sort array for ascending listing
    {
        copyLN.push(arrLastname[j])
    }
    copyLN.sort();

    document.getElementById("showlist").lastElementChild.innerHTML = "";

    for (var i = 0; i < arrLastname.length; i++)      // shows the inputs
    {
        pos = arrLastname.indexOf(copyLN[i]);
        document.getElementById("showlist").lastElementChild.innerHTML += "<tr><td>" +arrLastname[pos] + "</td> <td>"  + arrFirstname[pos] + "</td> <td>" +
            arrPhone[pos] + "</td>" + "<td>" + arrStreetaddress[pos] + "</td>" +  "<td>" + arrCity[pos] + "</td></tr>";
    }

}
