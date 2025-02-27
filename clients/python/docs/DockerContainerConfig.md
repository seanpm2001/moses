# DockerContainerConfig

Configuration for a container that is portable between hosts

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**hostname** | **str** | The hostname to use for the container, as a valid RFC 1123 hostname. | [optional] 
**domainname** | **str** | The domain name to use for the container. | [optional] 
**user** | **str** | The user that commands are run as inside the container. | [optional] 
**attach_stdin** | **bool** | Whether to attach to &#x60;stdin&#x60;. | [optional]  if omitted the server will use the default value of False
**attach_stdout** | **bool** | Whether to attach to &#x60;stdout&#x60;. | [optional]  if omitted the server will use the default value of True
**attach_stderr** | **bool** | Whether to attach to &#x60;stderr&#x60;. | [optional]  if omitted the server will use the default value of True
**exposed_ports** | **{str: (bool, date, datetime, dict, float, int, list, str, none_type,)}** | An object mapping ports to an empty object in the form:  &#x60;{\&quot;&lt;port&gt;/&lt;tcp|udp|sctp&gt;\&quot;: {}}&#x60;  | [optional] 
**tty** | **bool** | Attach standard streams to a TTY, including &#x60;stdin&#x60; if it is not closed. | [optional]  if omitted the server will use the default value of False
**open_stdin** | **bool** | Open &#x60;stdin&#x60; | [optional]  if omitted the server will use the default value of False
**stdin_once** | **bool** | Close &#x60;stdin&#x60; after one attached client disconnects | [optional]  if omitted the server will use the default value of False
**env** | **[str]** | A list of environment variables to set inside the container in the form &#x60;[\&quot;VAR&#x3D;value\&quot;, ...]&#x60;. A variable without &#x60;&#x3D;&#x60; is removed from the environment, rather than to have an empty value.  | [optional] 
**cmd** | **[str]** | Command to run specified as a string or an array of strings. | [optional] 
**healthcheck** | [**DockerHealthConfig**](DockerHealthConfig.md) |  | [optional] 
**args_escaped** | **bool** | Command is already escaped (Windows only) | [optional] 
**image** | **str** | The name of the image to use when creating the container | [optional] 
**volumes** | **{str: (bool, date, datetime, dict, float, int, list, str, none_type,)}** | An object mapping mount point paths inside the container to empty objects. | [optional] 
**working_dir** | **str** | The working directory for commands to run in. | [optional] 
**entrypoint** | **[str]** | The entry point for the container as a string or an array of strings.  If the array consists of exactly one empty string (&#x60;[\&quot;\&quot;]&#x60;) then the entry point is reset to system default (i.e., the entry point used by docker when there is no &#x60;ENTRYPOINT&#x60; instruction in the &#x60;Dockerfile&#x60;).  | [optional] 
**network_disabled** | **bool** | Disable networking for the container. | [optional] 
**mac_address** | **str** | MAC address of the container. | [optional] 
**on_build** | **[str]** | &#x60;ONBUILD&#x60; metadata that were defined in the image&#39;s &#x60;Dockerfile&#x60;. | [optional] 
**labels** | **{str: (str,)}** | User-defined key/value metadata. | [optional] 
**stop_signal** | **str** | Signal to stop a container as a string or unsigned integer. | [optional]  if omitted the server will use the default value of "SIGTERM"
**stop_timeout** | **int** | Timeout to stop a container in seconds. | [optional] 
**shell** | **[str]** | Shell for when &#x60;RUN&#x60;, &#x60;CMD&#x60;, and &#x60;ENTRYPOINT&#x60; uses a shell. | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


