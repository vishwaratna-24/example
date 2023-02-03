pipeline {
     agent any    
  stages {
        stage('Build') {
            steps {
                echo 'Build completed'
            }
        }
        stage('Build docker image') {
            steps {
                powershell 'docker build -f testing/Dockerfile -t iamvrs/testing .'
            }
        }
        stage('Deploy') {
            steps {
                powershell 'docker run -p 8081:80 iamvrs/testing'
            }
        }
    }
}
