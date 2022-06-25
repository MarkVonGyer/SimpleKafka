# SimpleKafka
An open source library designed to make it easy to work with Kafka in .NET Core

# Authors
Mark VonGyer,
Marin Dimitrov

# Retry Behaviour
Simple Kafka utilises the leaky bucket approach to retry behaviour. There are fundamentally two routes a message can take when a failure occurs. If a no retry exception is raised the message will not be retried. This is because there is no benefit to retrying the processing as it is guaranteed to fail again without an application update. You can inherit from the NoRetry exception and throw this in your code to handle specific scenarios where you do not want to retry. By default Simple Kafka will raise a no retry behaviour in the following scenarios:

* Parse failure

Any other exceptions raised will result in the retry behavour being followed. Each retry behaviour is configured by adding a delay interval between attempts. If no delay interval is specified then all errors will go straight to the deadletter topic. You cannot opt out of having a deadletter topic. Typically you will want shorter periods between earlier retries in order to maintain service levels and best keep order of execution in line. Later retries should have longer delays to account for more long term issues such as an infrastructure outage. This will allow your consumers to run the message when the system is stable again without having to migrate messages from the dead letter topic.

![alt text](https://github.com/MarkVonGyer/SimpleKafka/blob/main/Resources/Retry_Behaviour.png?raw=true)

