

let scratchNumber = 9;


function ScratchScratchCard(scratchId) {
    document.getElementById(scratchId).src = "images/page3Images/UsedRedScratch.png";
}

function RepairScretchCard(scratchId) {
    document.getElementById(scratchId).src = "images/page3Images/NewRedScratch.png";
}

function DisplayScratches() {

    let scratchSection = document.getElementById('scratch-section');
    /*scratchSection.innerHTML = "";*/

    
    for (let i = 0; i < scratchNumber; i++) {
        scratchSection.innerHTML +=
            '<img id= "'+ i + '" src="images/page3Images/NewRedScratch.png" ' +
            'class="scratch" onclick= ScratchScratchCard("' + i + '") /> ';
    }
}