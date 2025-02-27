# DockerContainerState

The state of the container.

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**status** | **str** | The status of the container. For example, &#x60;\&quot;running\&quot;&#x60; or &#x60;\&quot;exited\&quot;&#x60;.  | [optional] 
**running** | **bool** | Whether this container is running.  Note that a running container can be _paused_. The &#x60;Running&#x60; and &#x60;Paused&#x60; booleans are not mutually exclusive:  When pausing a container (on Linux), the cgroups freezer is used to suspend all processes in the container. Freezing the process requires the process to be running. As a result, paused containers are both &#x60;Running&#x60; _and_ &#x60;Paused&#x60;.  Use the &#x60;Status&#x60; field instead to determine if a container&#39;s state is \&quot;running\&quot;.  | [optional] 
**paused** | **bool** | Whether this container is paused. | [optional] 
**restarting** | **bool** | Whether this container is restarting. | [optional] 
**oom_killed** | **bool** | Whether this container has been killed because it ran out of memory. | [optional] 
**dead** | **bool** |  | [optional] 
**pid** | **int** | The process ID of this container | [optional] 
**exit_code** | **int** | The last exit code of this container | [optional] 
**error** | **str** |  | [optional] 
**started_at** | **str** | The time when this container was last started. | [optional] 
**finished_at** | **str** | The time when this container last exited. | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


