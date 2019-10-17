//CONSTANTS
//screen
SCREEN_WIDTH = 800;
SCREEN_HEIGHT = 400;

//images
POS_Y = 350;

//elements
ELEMENTS = ['ROCK', 'PAPER', 'SCISSORS', 'LIZARD', 'SPOCK'];
IMAGES = ['img/rock.png', 'img/paper.png', 'img/scissors.png', 'img/lizard.png', 'img/spck.png'];
POSITIONS = [[150, POS_Y], [250, POS_Y], [350, POS_Y], [450, POS_Y], [550, POS_Y]];

//rules
RULES_MATRIX = [
    [2, 0, 1, 1, 0],
    [1, 2, 0, 0, 1],
    [0, 1, 2, 1, 0],
    [0, 1, 0, 2, 1],
    [1, 0, 1, 0, 2]
];

class Button{
    constructor(index){
        this.index = index;
        this.name = ELEMENTS[index];
        this.x = POSITIONS[index][0];
        this.y = POSITIONS[index][1];
        this.image = IMAGES[index];
        this.button_object = null;
    }

    display(){
        this.button_object = createImg(this.image);
        this.button_object.position(this.x, this.y);
        this.button_object.mouseClicked(() => {
            select_element(this.index);
        });
    }
}

function setup(){
    createCanvas(SCREEN_WIDTH, SCREEN_HEIGHT);
    let buttons = createButtons();
    buttons.forEach(button => {
        button.display();
    });
}

function draw(){
    noFill();
    rect(0, 0, SCREEN_WIDTH, SCREEN_HEIGHT);
    rect(0, SCREEN_HEIGHT - 65, SCREEN_WIDTH, SCREEN_HEIGHT - 65);
}

function createButtons(){
    let buttons = []
    for(let i = 0; i < 5; i++){
        let button = new Button(i);
        buttons.push(button);
    }
    return buttons;
}

function select_element(index){
    clear();
    let selection = createImg(IMAGES[index]);
    selection.position(SCREEN_WIDTH / 2, SCREEN_HEIGHT - 150);
    //cpu selects his element
    let cpu_index_selected = cpu_selection();
    let win = checkWin(index, cpu_index_selected);
    let message = '';
    if(win == 0){
        message = "I'm sorry, you lose.";
    }
    if(win == 1){
        message = "Yey, you won!";
    }
    if(win == 2){
        message = "That's a draw.";
    }
    fill(0, 0, 0);
    textSize(24);
	text(message, (SCREEN_WIDTH / 2) - 50, SCREEN_HEIGHT / 2);
}

function cpu_selection(){
    let cpu_index = Math.floor(Math.random() * 5);
    let cpu_selection = createImg(IMAGES[cpu_index]);
    cpu_selection.position(SCREEN_WIDTH / 2, 50);
    return cpu_index;
}

function checkWin(first, second){
    return RULES_MATRIX[first][second];
}