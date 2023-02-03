pipeline {
    agent any

    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
            }
        }
        
        stage('Build') {
            steps {
                powershell 'docker build -f example/Dockerfile -t example .'
            }
        }
       
        stage('Deploy') {
            steps {
                powershell 'docker run -p 8081:80 example'
            }
        }
        
        
    }
}
