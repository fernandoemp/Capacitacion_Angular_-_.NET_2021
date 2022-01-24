
// IIFE, Immediately Invocated Function Expressions

(function dosomething() {
    console.log('IIFE executed')
})()


// BIND

const car = {
    maker: 'Ford',
    model: 'Fiesta',

    drive() {
        console.log(`Driving a ${this.maker} ${this.model} car!`)
    }
}

const anotherCar = {
    maker: 'Audi',
    model: 'A4'
}

car.drive.bind(anotherCar)()

//   const link = document.querySelector('#link')
//   link.addEventListener('click', () => {
//     // this === window
//   })

//   const link2 = document.querySelector('#link')
//   link2.addEventListener('click', function() {
//     // this === link2
//   })

// ARROW FUNCTION
const myArrowFunction = () => console.log('Arrow function');

//LOOPS 
const list = ['a', 'b', 'c']
//   for (let i = 0; i < list.length; i++) {
//     console.log(list[i]) //value
//     console.log(i) //index
//   }

//   list.forEach((item, index) => {
//     console.log(item) //value
//     console.log(index) //index
//   })


//   for (let property in object) {
//     console.log(property) //property name
//     console.log(object[property]) //property value
//   }

// for (const [index, value] of ['a', 'b', 'c'].entries()) {
//     console.log(index) //index
//     console.log(value) //value
//   }

// ARRAY

const a = [1, 2, 3, 4, 5, 6, 7, 8, 9] // its equal to
const b = Array.of(1, 2, 3)


console.log(a);

a.push(10);

console.log(a);

a.unshift(0)

console.log(a);

a.pop();

console.log(a);

a.shift();

console.log(a);


const matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

matrix[0][0] //1
matrix[2][0] //7

const result = a.find(x => x === 3);
console.log(result);

const result2 = a.findIndex(x => x === 3);
console.log(result2);

const myVariable = 'test'
const string = `something ${myVariable}`

console.log(string);


myArrowFunction();
