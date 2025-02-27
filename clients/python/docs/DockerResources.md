# DockerResources

A container's resources (cgroups config, ulimits, etc)

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cpu_shares** | **int** | An integer value representing this container&#39;s relative CPU weight versus other containers. | [optional] 
**memory** | **int** | Memory limit in bytes. | [optional]  if omitted the server will use the default value of 0
**cgroup_parent** | **str** | Path to &#x60;cgroups&#x60; under which the container&#39;s &#x60;cgroup&#x60; is created. If the path is not absolute, the path is considered to be relative to the &#x60;cgroups&#x60; path of the init process. Cgroups are created if they do not already exist. | [optional] 
**blkio_weight** | **int** | Block IO weight (relative weight). | [optional] 
**blkio_weight_device** | [**[DockerResourcesBlkioWeightDeviceInner]**](DockerResourcesBlkioWeightDeviceInner.md) | Block IO weight (relative device weight) in the form &#x60;[{\&quot;Path\&quot;: \&quot;device_path\&quot;, \&quot;Weight\&quot;: weight}]&#x60;.  | [optional] 
**blkio_device_read_bps** | [**[DockerThrottleDevice]**](DockerThrottleDevice.md) | Limit read rate (bytes per second) from a device, in the form &#x60;[{\&quot;Path\&quot;: \&quot;device_path\&quot;, \&quot;Rate\&quot;: rate}]&#x60;.  | [optional] 
**blkio_device_write_bps** | [**[DockerThrottleDevice]**](DockerThrottleDevice.md) | Limit write rate (bytes per second) to a device, in the form &#x60;[{\&quot;Path\&quot;: \&quot;device_path\&quot;, \&quot;Rate\&quot;: rate}]&#x60;.  | [optional] 
**blkio_device_read_i_ops** | [**[DockerThrottleDevice]**](DockerThrottleDevice.md) | Limit read rate (IO per second) from a device, in the form &#x60;[{\&quot;Path\&quot;: \&quot;device_path\&quot;, \&quot;Rate\&quot;: rate}]&#x60;.  | [optional] 
**blkio_device_write_i_ops** | [**[DockerThrottleDevice]**](DockerThrottleDevice.md) | Limit write rate (IO per second) to a device, in the form &#x60;[{\&quot;Path\&quot;: \&quot;device_path\&quot;, \&quot;Rate\&quot;: rate}]&#x60;.  | [optional] 
**cpu_period** | **int** | The length of a CPU period in microseconds. | [optional] 
**cpu_quota** | **int** | Microseconds of CPU time that the container can get in a CPU period. | [optional] 
**cpu_realtime_period** | **int** | The length of a CPU real-time period in microseconds. Set to 0 to allocate no time allocated to real-time tasks. | [optional] 
**cpu_realtime_runtime** | **int** | The length of a CPU real-time runtime in microseconds. Set to 0 to allocate no time allocated to real-time tasks. | [optional] 
**cpuset_cpus** | **str** | CPUs in which to allow execution (e.g., &#x60;0-3&#x60;, &#x60;0,1&#x60;) | [optional] 
**cpuset_mems** | **str** | Memory nodes (MEMs) in which to allow execution (0-3, 0,1). Only effective on NUMA systems. | [optional] 
**devices** | [**[DockerDeviceMapping]**](DockerDeviceMapping.md) | A list of devices to add to the container. | [optional] 
**device_cgroup_rules** | **[str]** | a list of cgroup rules to apply to the container | [optional] 
**disk_quota** | **int** | Disk limit (in bytes). | [optional] 
**kernel_memory** | **int** | Kernel memory limit in bytes. | [optional] 
**memory_reservation** | **int** | Memory soft limit in bytes. | [optional] 
**memory_swap** | **int** | Total memory limit (memory + swap). Set as &#x60;-1&#x60; to enable unlimited swap. | [optional] 
**memory_swappiness** | **int, none_type** | Tune a container&#39;s memory swappiness behavior. Accepts an integer between 0 and 100. | [optional] 
**nano_cpus** | **int** | CPU quota in units of 10&lt;sup&gt;-9&lt;/sup&gt; CPUs. | [optional] 
**oom_kill_disable** | **bool** | Disable OOM Killer for the container. | [optional] 
**init** | **bool, none_type** | Run an init inside the container that forwards signals and reaps processes. This field is omitted if empty, and the default (as configured on the daemon) is used. | [optional] 
**pids_limit** | **int, none_type** | Tune a container&#39;s pids limit. Set -1 for unlimited. | [optional] 
**ulimits** | [**[DockerResourcesUlimitsInner]**](DockerResourcesUlimitsInner.md) | A list of resource limits to set in the container. For example: &#x60;{\&quot;Name\&quot;: \&quot;nofile\&quot;, \&quot;Soft\&quot;: 1024, \&quot;Hard\&quot;: 2048}&#x60;\&quot;  | [optional] 
**cpu_count** | **int** | The number of usable CPUs (Windows only).  On Windows Server containers, the processor resource controls are mutually exclusive. The order of precedence is &#x60;CPUCount&#x60; first, then &#x60;CPUShares&#x60;, and &#x60;CPUPercent&#x60; last.  | [optional] 
**cpu_percent** | **int** | The usable percentage of the available CPUs (Windows only).  On Windows Server containers, the processor resource controls are mutually exclusive. The order of precedence is &#x60;CPUCount&#x60; first, then &#x60;CPUShares&#x60;, and &#x60;CPUPercent&#x60; last.  | [optional] 
**io_maximum_i_ops** | **int** | Maximum IOps for the container system drive (Windows only) | [optional] 
**io_maximum_bandwidth** | **int** | Maximum IO in bytes per second for the container system drive (Windows only) | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


