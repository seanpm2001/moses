# DockerNetworkSettings

NetworkSettings exposes the network settings in the API

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bridge** | **str** | Name of the network&#39;a bridge (for example, &#x60;docker0&#x60;). | [optional] 
**sandbox_id** | **str** | SandboxID uniquely represents a container&#39;s network stack. | [optional] 
**hairpin_mode** | **bool** | Indicates if hairpin NAT should be enabled on the virtual interface.  | [optional] 
**link_local_ipv6_address** | **str** | IPv6 unicast address using the link-local prefix. | [optional] 
**link_local_ipv6_prefix_len** | **int** | Prefix length of the IPv6 unicast address. | [optional] 
**ports** | [**DockerPortMap**](DockerPortMap.md) |  | [optional] 
**sandbox_key** | **str** | SandboxKey identifies the sandbox | [optional] 
**secondary_ip_addresses** | [**[DockerAddress], none_type**](DockerAddress.md) |  | [optional] 
**secondary_ipv6_addresses** | [**[DockerAddress], none_type**](DockerAddress.md) |  | [optional] 
**endpoint_id** | **str** | EndpointID uniquely represents a service endpoint in a Sandbox.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**gateway** | **str** | Gateway address for the default \&quot;bridge\&quot; network.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**global_ipv6_address** | **str** | Global IPv6 address for the default \&quot;bridge\&quot; network.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**global_ipv6_prefix_len** | **int** | Mask length of the global IPv6 address.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**ip_address** | **str** | IPv4 address for the default \&quot;bridge\&quot; network.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**ip_prefix_len** | **int** | Mask length of the IPv4 address.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**ipv6_gateway** | **str** | IPv6 gateway address for this network.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**mac_address** | **str** | MAC address for the container on the default \&quot;bridge\&quot; network.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Deprecated**: This field is only propagated when attached to the &gt; default \&quot;bridge\&quot; network. Use the information from the \&quot;bridge\&quot; &gt; network inside the &#x60;Networks&#x60; map instead, which contains the same &gt; information. This field was deprecated in Docker 1.9 and is scheduled &gt; to be removed in Docker 17.12.0  | [optional] 
**networks** | [**{str: (DockerEndpointSettings,)}**](DockerEndpointSettings.md) | Information about all networks that the container is connected to.  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


