namespace Server
{
	public class DefaultEnvVars
	{
		public static string ALLOW_FLIGHT { get; } = "false";
		public static string ALLOW_NETHER { get; } = "true";
		public static string BROADCAST_CONSOLE_TO_OPS { get; } = "true";
		public static string BROADCAST_RCON_TO_OPS { get; } = "true";
		public static string DIFFICULTY { get; } = "easy";
		public static string ENABLE_COMMAND_BLOCK { get; } = "true";
		public static string ENABLE_JMX_MONITORING { get; } = "true";
		public static string ENABLE_RCON { get; } = "false";
		public static string SYNC_CHUNK_WRITES { get; } = "true";
		public static string ENABLE_STATUS { get; } = "true";
		public static string ENABLE_QUERY { get; } = "false";
		public static string ENTITY_BROADCAST_RANGE_PERCENTAGE { get; } = "100";
		public static string FORCE_GAMEMODE { get; } = "true";
		public static string FUNCTION_PERMISSION_LEVEL { get; } = "2";
		public static string GAMEMODE { get; } = "survival";
		public static string GENERATE_STRUCTURES { get; } = "true";
		public static string GENERATOR_SETTINGS { get; } = "";
		public static string HARDCORE { get; } = "false";
		public static string LEVEL_NAME { get; } = "world";
		public static string LEVEL_SEED { get; } = "";
		public static string LEVEL_TYPE { get; } = "default";
		public static string MAX_BUILD_HEIGHT { get; } = "256";
		public static string MAX_PLAYERS { get; } = "20";
		public static string MAX_TICK_TIME { get; } = "60000";
		public static string MAX_WORLD_SIZE { get; } = "29999984";
		public static string MOTD { get; } = "A Minecraft Server";
		public static string NETWORK_COMPRESSION_THRESHOLD { get; } = "256";
		public static string ONLINE_MODE { get; } = "true";
		public static string OP_PERMISSION_LEVEL { get; } = "4";
		public static string PLAYER_IDLE_TIMEOUT { get; } = "0";
		public static string PREVENT_PROXY_CONNECTION { get; } = "false";
		public static string PVP { get; } = "true";
		public static string QUERY_PORT { get; } = "25565";
		public static string RATE_LIMIT { get; } = "0";
		public static string RCON_PASSWORD { get; } = "";
		public static string RCON_PORT { get; } = "25575";
		public static string RESOURCE_PACK { get; } = "";
		public static string RESOURCE_PACK_SHA1 { get; } = "";
		public static string SERVER_IP { get; } = "";
		public static string SERVER_PORT { get; } = "25565";
		public static string SNOOPER_ENABLED { get; } = "true";
		public static string SPAWN_ANIMALS { get; } = "true";
		public static string SPAWN_MONSTERS { get; } = "true";
		public static string SPAWN_NPCS { get; } = "true";
		public static string SPAWN_PROTECTION { get; } = "16";
		public static string USE_NATIVE_TRANSPORT { get; } = "true";
		public static string VIEW_DISTANCE { get; } = "10";
		public static string WHITE_LIST { get; } = "false";
		public static string ENFORCE_WHITELIST { get; } = "false";
	}
}