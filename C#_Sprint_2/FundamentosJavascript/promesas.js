

// Promesas

//Creating a promise

let done = true

const isItDoneYet = new Promise((resolve, reject) => {
  if (done) {
    const workDone = 'Here is the thing I built'
    resolve(workDone)
  } else {
    const why = 'Still working on something else'
    reject(why)
  }
})

// Consuming a promise

const checkIfItsDone = () => {
  isItDoneYet
    .then(ok => {
      console.log('success')
      console.log(ok)
    })
    .catch(err => {
      console.log('error')
      console.error(err)
    })
}
// console.log(isItDoneYet)

checkIfItsDone();