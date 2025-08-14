function movies (inpurArr){
    let allMovies = []

    for (const commandLine of inpurArr) {
        if (commandLine.startsWith('addMovie')){

            let movieName = commandLine.substring(9)
            allMovies.push({'name': movieName})

        } else if (commandLine.includes('directedBy')) {
            let [movieName, directorName] = commandLine.split(' directedBy ')

            let movie = allMovies.find(m => m.name === movieName) 

            if(movie) {
                movie.director = directorName
            }
        } else if (commandLine.includes('onDate')){
            let [movieName, movieDate] = commandLine.split(' onDate ')

            let movie = allMovies.find(m => m.name === movieName)

            if(movie){
                movie.date = movieDate 
            }
        }
    }

    for (const movie of allMovies) {
        if(movie.director && movie.date){
            console.log(JSON.stringify(movie))
        }
    }
}