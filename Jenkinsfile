pipeline {
    agent any

    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
            }
        }
        
        stage('Build docker image') {
            steps {
                powershell 'docker build -f example/Dockerfile -t binarythis/example .'
            }
        }
       
        stage('Deploy') {
            steps {
                powershell 'docker run -p 8081:80 binarythis/example'
            }
        }
        
        
    }
}
